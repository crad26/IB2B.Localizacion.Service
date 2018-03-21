using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Tesseract;
using System.IO;
using System.Drawing;
using System.Web.Hosting;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace IB2B.Localizacion.Service.DataContract.SUNAT
{
    public class ConectionSunat
    {
        public ConectionSunat()
        {
            myCookie = null;
            myCookie = new CookieContainer();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
        }

        public enum Resul
        {
            Ok = 0,
            NoResul = 1,
            ErrorCapcha = 2,
            Error = 3,
        }







        private static CookieContainer myCookie;
        //public Image GetCapcha { get { return ReadCapcha(); } }
        public String TextoCapcha = String.Empty;
        TesseractEngine engine;












        private Boolean ValidarCertificado(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        //Aqui obtenemos el captcha
        private String ReadCapcha()
        {
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(ValidarCertificado);
                //Esta es la direccion que les pase en el grupo de facebook para obtener el captcha
                //HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://www.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image&magic=2");
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image&magic=2");
                myWebRequest.CookieContainer = myCookie;
                myWebRequest.Proxy = null;
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myImgStream = myWebResponse.GetResponseStream();
                //Modificación 1 ... Esta fue la primera modificación ... cree un mapa de bits que utilizaré como
                //parámetro para en fin ... mejor se los muestro xd
                Bitmap bm = new Bitmap(Image.FromStream(myImgStream));
                //quitamos el color a nuestro mapa de bits 
                qutarColor(bm);
                //Procesamos la imagen (separación de carácteres, alineación etc)
                //Y se devuelve la imagen lista para ser procesada por el OCR

                //Recordemos que el metodo ( si ya obviaré las tildes ) ... 
                // el metodo ReadCapcha devuelve la imagen ya procesada ...
                using (Bitmap bm2 = new Bitmap((Image)PreProcessImage(bm)))
                {
                    //Instanciamos el TesseractEngine declarado arriba !
                    //engine = new TesseractEngine(@".\tessdata", "eng", EngineMode.Default);
                    string dataPath = HostingEnvironment.MapPath(@"~/tessdata");
                    //string dataPath = @"E:\Mario\Proyectos\IB2B.LocalizacionNew\IB2B.Localizacion\IB2B.Localizacion.Web\tessdata";

                    engine = new TesseractEngine(dataPath, "eng", EngineMode.Default);
                    engine.DefaultPageSegMode = PageSegMode.SingleBlock;
                    Tesseract.Page p = engine.Process(bm2);
                    TextoCapcha = p.GetText().Trim().ToUpper().Replace(" ", "");
                    //  Console.WriteLine("Text recognized: " + text);
                }
                return TextoCapcha;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //En este metodo es el que utiliza el tesseract ... se obtiene la imagen del captcha terminada
        // y devuelve el texto obtenido ...
        public string UseTesseract()
        {

            string text = String.Empty;
            //Recordemos que el metodo ( si ya obviaré las tildes ) ... 
            // el metodo ReadCapcha devuelve la imagen ya procesada ...
            using (Bitmap bm = new Bitmap(ReadCapcha()))
            {
                //Instanciamos el TesseractEngine declarado arriba !
                engine = new TesseractEngine(@".\tessdata", "eng", EngineMode.Default);
                engine.DefaultPageSegMode = PageSegMode.SingleBlock;
                Tesseract.Page p = engine.Process(bm);
                text = p.GetText().Trim().ToUpper().Replace(" ", "");
                //  Console.WriteLine("Text recognized: " + text);
            }
            //Retornamos luego del trabajo del OCR el texto obtenido 
            return text;
        }
        //En este metodo se procesa la imagen, se separan los caracteres de manera individual
        private static Bitmap PreProcessImage(Bitmap memStream)
        {
            Bitmap bm = memStream;
            // Flatten Image to Black and White
            qutarColor(bm);

            // We have a know 6 charcter captcha
            List<Rectangle> charcters = new List<Rectangle>();
            List<int> blackin_x = new List<int>();

            int x_max = bm.Width - 1;
            int y_max = bm.Height - 1;

            // Here we are going to scan through the columns to determine if there in any black in them (charcter)
            for (int temp_x = 0; temp_x <= x_max; temp_x++)
            {
                for (int temp_y = 0; temp_y <= y_max; temp_y++)
                {
                    if (bm.GetPixel(temp_x, temp_y).Name != "ffffffff")
                    {
                        blackin_x.Add(temp_x);
                        break;
                    }
                }
            }

            // Building inital rectangles with X Boundaries
            // This is where we are using our previous results to build the horiztonal boundaries of our charcters
            int temp_start = blackin_x[0];
            for (int temp_x = 0; temp_x < blackin_x.Count - 1; temp_x++)
            {
                if (temp_x == blackin_x.Count - 2) // handles the last iteration
                {
                    Rectangle r = new Rectangle();
                    r.X = temp_start;
                    r.Width = blackin_x[temp_x] - r.X + 2;

                    charcters.Add(r);
                }
                if (blackin_x[temp_x] - blackin_x[temp_x + 1] == -1)
                {
                    continue;
                }
                else
                {
                    Rectangle r = new Rectangle();
                    r.X = temp_start;
                    r.Width = blackin_x[temp_x] - r.X + 1;
                    temp_start = blackin_x[temp_x + 1];
                    charcters.Add(r);
                }

            }

            // Finish out by getting y boundaries
            for (int i = 0; i < charcters.Count; i++)
            {
                Rectangle r = charcters[i];

                for (int temp_y = 0; temp_y < y_max; temp_y++)
                {
                    if (r.Y == 0)
                    {
                        if (!IsRowWhite(bm, temp_y, r.X, r.X + r.Width - 1))
                            r.Y = temp_y;
                    }
                    else if (r.Height == 0)
                    {
                        if (IsRowWhite(bm, temp_y, r.X, r.X + r.Width - 1))
                            r.Height = temp_y - r.Y + 1;
                    }
                    else
                        break;

                }

                charcters[i] = r; // have to do this as rectangle is struct

            }

            int totalWidth = 1 + charcters.Sum(o => o.Width) + (charcters.Count * 2); // we need padding
            int totalHeight = charcters.Max(o => o.Height) + 2; // padding here too 
            int current_x = 1; // start off the left edge 1px

            Bitmap bmp = new Bitmap(totalWidth, totalHeight);
            Graphics g = Graphics.FromImage(bmp);

            // the following four lines are added to help image quality
            g.Clear(Color.White);
            g.InterpolationMode = InterpolationMode.High;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // take our four charcters and move them into a new bitmap 
            foreach (Rectangle r in charcters)
            {
                g.DrawImage(bm, current_x, 1, r, GraphicsUnit.Pixel);
                current_x += r.Width + 2;
            }

            //  bmp.Save(@"C:\postprocess.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            return bmp;
        }

        /// <summary>
        /// Determines whether the specified row in the bitmap contains white.
        /// </summary>
        /// <param name="bm">The Image.</param>
        /// <param name="temp_y">The temp_y.</param>
        /// <param name="x">The x.</param>
        /// <param name="width">The width.</param>
        /// <returns></returns>
        private static bool IsRowWhite(Bitmap bm, int temp_y, int x, int width)
        {
            for (int i = x; i < width; i++)
            {
                if (bm.GetPixel(i, temp_y).Name != "ffffffff")
                    return false;
            }
            return true;
        }
        // Aqui quitamos el color ... lo dejamos en blanco y negro (El captcha)
        public static void qutarColor(Bitmap bm)
        {
            for (int x = 0; x < bm.Width; x++)
                for (int y = 0; y < bm.Height; y++)
                {
                    Color pix = bm.GetPixel(x, y);
                    //Aqui puedes jugar con los valores del brillo yo he probado poco pero tu puedes cambiarlo
                    if (pix.GetBrightness() > 0.870f)
                    {
                        bm.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        bm.SetPixel(x, y, Color.Black);
                    }
                }
        }

        public DatosSUNATBE GetInfo(String pNumero)
        {
            DatosSUNATBE obDatosSUNATBE = new DatosSUNATBE();
            bool ValidarRegistro = false;
            try
            {
                //A este link le pasamos los datos , RUC y valor del captcha
                /*string myUrl = String.Format("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc={0}&codigo={1}",
                                        pNumero, pImgCapcha);*/
                string myUrl = String.Format("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc={0}&codigo={1}",
                                        pNumero, ReadCapcha().ToString());

                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(myUrl);
                myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
                myWebRequest.CookieContainer = myCookie;
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myStream = myHttpWebResponse.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myStream);
                //Leemos los datos
                string xDat = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
                if (xDat.Length <= 635)
                {
                    return obDatosSUNATBE;
                }
                string[] tabla;
                xDat = xDat.Replace("     ", " ");
                xDat = xDat.Replace("    ", " ");
                xDat = xDat.Replace("   ", " ");
                xDat = xDat.Replace("  ", " ");
                xDat = xDat.Replace("( ", "(");
                xDat = xDat.Replace(" )", ")");
                //Lo convertimos a tabla o mejor dicho a un arreglo de string como se ve declarado arriba
                tabla = Regex.Split(xDat, "<td class");
                Int32 cIndexTipoDocumento = -1;
                Int32 cIndexNombreComercial = -1;
                Int32 cIndexFechaInscripcion = -1;
                Int32 cIndexFechaInicioAct = -1;
                Int32 cIndexEstadoContribuyente = -1;
                Int32 cIndexCondicionContribuyente = -1;
                Int32 cIndexDireccion = -1;
                Int32 cIndexTelefono = -1;
                Int32 cIndexSistemaEmisionComp = -1;
                Int32 cIndexActividadComercioExter = -1;
                Int32 cIndexSistemaEmisionElec = -1;
                Int32 cIndexEmisorCorreoDesde = -1;
                Int32 cIndexComprobanteElectronica = -1;
                Int32 cIndexAfiliadoPLE = -1;
                Int32 cIndexPadrones = -1;
                Int32 cIndexSistemContabilidad = -1;
                Int32 cIndexActividadEconomica = -1;
                obDatosSUNATBE.RUC = pNumero;
                if (tabla.Length == 1)
                    return new DatosSUNATBE();
                else if (tabla.Length <= 4)
                {
                    obDatosSUNATBE.MensajeError = "El número de RUC " + pNumero + ", consultado no es válido.";
                    return obDatosSUNATBE;
                }
                obDatosSUNATBE.RazonSocial = tabla[1].Replace("=\"bg\" colspan=3>" + pNumero + " - ", String.Empty).Split('<')[0];
                obDatosSUNATBE.NombreNatural = tabla[5].Replace("=\"bg\" colspan=3>", String.Empty).Split('<')[0];
                obDatosSUNATBE.TipoContribuyente = tabla[3].Replace("=\"bg\" colspan=3>", String.Empty).Split('<')[0];
                obDatosSUNATBE.TipoDocumento = String.Empty;
                for (int i = 0; i < tabla.Length; i++)
                {
                    if (tabla[i].IndexOf("Tipo de Documento") != -1 && cIndexTipoDocumento == -1)
                        cIndexTipoDocumento = i + 1;
                    else if (tabla[i].IndexOf("Nombre Comercial") != -1 && cIndexNombreComercial == -1)
                        cIndexNombreComercial = i + 1;
                    else if (tabla[i].IndexOf("Fecha de Inscripción") != -1 && cIndexFechaInscripcion == -1)
                        cIndexFechaInscripcion = i + 1;
                    else if (tabla[i].IndexOf("Fecha de Inicio de Actividades") != -1 && cIndexFechaInicioAct == -1)
                        cIndexFechaInicioAct = i + 1;
                    else if (tabla[i].IndexOf("Estado del Contribuyente") != -1 && cIndexEstadoContribuyente == -1)
                        cIndexEstadoContribuyente = i + 1;
                    else if (tabla[i].IndexOf("Condición del Contribuyente") != -1 && cIndexCondicionContribuyente == -1)
                        cIndexCondicionContribuyente = i + 1;
                    else if (tabla[i].IndexOf("Dirección del Domicilio") != -1 && cIndexDireccion == -1)
                        cIndexDireccion = i + 1;
                    else if (tabla[i].IndexOf("Teléfono") != -1 && cIndexTelefono == -1)
                        cIndexTelefono = i + 1;
                    else if (tabla[i].IndexOf("Sistema de Emisión de Comprobante") != -1 && cIndexSistemaEmisionComp == -1)
                        cIndexSistemaEmisionComp = i + 1;
                    else if (tabla[i].IndexOf("Actividad de Comercio Exterior") != -1 && cIndexActividadComercioExter == -1)
                        cIndexActividadComercioExter = i + 1;
                    else if (tabla[i].IndexOf("Sistema de Emision Electronica") != -1 && cIndexSistemaEmisionElec == -1)
                        cIndexSistemaEmisionElec = i + 1;
                    else if (tabla[i].IndexOf("Emisor electrónico desde") != -1 && cIndexEmisorCorreoDesde == -1)
                        cIndexEmisorCorreoDesde = i + 1;
                    else if (tabla[i].IndexOf("Comprobantes Electrónicos") != -1 && cIndexComprobanteElectronica == -1)
                        cIndexComprobanteElectronica = i + 1;
                    else if (tabla[i].IndexOf("Afiliado al PLE desde") != -1 && cIndexAfiliadoPLE == -1)
                        cIndexAfiliadoPLE = i + 1;
                    else if (tabla[i].IndexOf("Padrones") != -1 && cIndexPadrones == -1)
                        cIndexPadrones = i + 1;
                    else if (tabla[i].IndexOf("Sistema de Contabilidad") != -1 && cIndexSistemContabilidad == -1)
                        cIndexSistemContabilidad = i + 1;
                    else if (tabla[i].IndexOf("Actividad(es) Económica(s)") != -1 && cIndexActividadEconomica == -1)
                        cIndexActividadEconomica = i + 2;
                }
                if (cIndexTipoDocumento != -1)
                    obDatosSUNATBE.TipoDocumento = tabla[cIndexTipoDocumento].Replace("=\"bg\" colspan=3>", "").Replace(" - " + obDatosSUNATBE.RazonSocial, String.Empty).Split('-')[0].Trim();
                obDatosSUNATBE.NombreComercial = tabla[cIndexNombreComercial].Replace("=\"bg\" colspan=1>", String.Empty).Split('<')[0];
                obDatosSUNATBE.FechaInscripcion = tabla[cIndexFechaInscripcion].Replace("=\"bg\" colspan=1>", String.Empty).Split('<')[0];
                obDatosSUNATBE.FechaInicioActividades = tabla[cIndexFechaInicioAct].Replace("=\"bg\" colspan=1>", String.Empty).Split('<')[0];
                obDatosSUNATBE.EstadoContribuyente = tabla[cIndexEstadoContribuyente].Replace("=\"bg\" colspan=1>", String.Empty).Split('<')[0].Trim();
                if (tabla[cIndexCondicionContribuyente].IndexOf("NO HABIDO") == -1)
                    obDatosSUNATBE.CondicionContribuyente = tabla[cIndexCondicionContribuyente].Replace("=\"bg\" colspan=3>", String.Empty).Split('<')[0].Trim();
                else
                    obDatosSUNATBE.CondicionContribuyente = "NO HABIDO";
                obDatosSUNATBE.DomicilioFiscal = tabla[cIndexDireccion].Replace("=\"bg\" colspan=3>", String.Empty).Replace("</td>\r\n </tr>\r\n<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->\r\n<!-- <tr> -->\r\n<!-- ", "");
                obDatosSUNATBE.Telefono = tabla[cIndexTelefono].Replace("=\"bg\" colspan=1>", String.Empty).Split('<')[0];
                obDatosSUNATBE.SistemaEmisionComprobante = tabla[cIndexSistemaEmisionComp].Replace("=\"bg\" colspan=1>", String.Empty).Split('<')[0];
                obDatosSUNATBE.ActividadComercioExterior = tabla[cIndexActividadComercioExter].Replace("=\"bg\" colspan=1>", String.Empty).Split('<')[0];
                obDatosSUNATBE.SistemaContabilidad = tabla[cIndexSistemContabilidad].Replace("=\"bg\" colspan=1>", String.Empty).Split('<')[0];
                if (tabla[cIndexActividadEconomica].IndexOf("option") != -1)
                    obDatosSUNATBE.ActividadEconomica = tabla[cIndexActividadEconomica].Replace("option", "|").Split('|')[3].Split('>')[1].Split('<')[0].Trim();
                else
                    obDatosSUNATBE.ActividadEconomica = tabla[cIndexActividadEconomica - 1].Replace("=\"bg\" colspan=3>", String.Empty).Split('<')[0].Trim();
                if (tabla[cIndexSistemaEmisionElec].IndexOf("colspan") != -1)
                    obDatosSUNATBE.SistemaEmisionElectronica = tabla[cIndexSistemaEmisionElec].Replace("=\"bg\" colspan=3>", String.Empty).Split('<')[0].Trim();
                else
                {
                    obDatosSUNATBE.SistemaEmisionElectronica = tabla[32].Replace("option", "|");
                    if (obDatosSUNATBE.SistemaEmisionElectronica.IndexOf('|') != -1)
                        obDatosSUNATBE.SistemaEmisionElectronica = obDatosSUNATBE.SistemaEmisionElectronica.Split('|')[1].Trim().Split('>')[1].Split('<')[0];
                    else
                        obDatosSUNATBE.SistemaEmisionElectronica = "-";
                }
                obDatosSUNATBE.EmisionElectronicaDesde = tabla[cIndexEmisorCorreoDesde].Replace("=\"bg\" colspan=3>", String.Empty).Split('<')[0].Trim();
                obDatosSUNATBE.ComprobanteElectronica = tabla[cIndexComprobanteElectronica].Replace("=\"bg\" colspan=3>", String.Empty).Split('<')[0].Trim();
                obDatosSUNATBE.AfiliadoPLEDesde = tabla[cIndexAfiliadoPLE].Replace("=\"bg\" colspan=3>", String.Empty).Split('<')[0].Trim();
                obDatosSUNATBE.Padrones = tabla[cIndexPadrones].Replace("option", "|").Trim().Split('|')[1].Trim().Split('>')[1].Split('<')[0];
                obDatosSUNATBE.ValidarRegistro = true;
            }
            catch (Exception ex)
            {
                obDatosSUNATBE.ValidarRegistro = false;
                obDatosSUNATBE.MensajeError = ex.Message;
            }
            return obDatosSUNATBE;
        }
    }
}