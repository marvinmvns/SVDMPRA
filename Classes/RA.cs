using System;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace tela.Classes
{
    public class RA
    {
        public void RAC()
        {
            string sysDrive = System.Environment.GetEnvironmentVariable("SystemDrive") + @"\SVDMPRA\Sistema\";
            string filePath = Path.Combine(sysDrive, "svdmpra.cfg");
            Stream st = File.Open(filePath, FileMode.Create);
            StreamWriter s = new StreamWriter(st);
            s.WriteLine("#");
            s.WriteLine("#Arquivo de Configuração SVDMP-RA");  
            s.WriteLine("#Carregamento dos drivers de video");
            s.WriteLine("");
            s.WriteLine("video artoolkit2");
            s.WriteLine("tracker artoolkit2");
            s.WriteLine("");
            s.Close();
        }
        public void RAGERA(int contador, string marcador, int tx, int ty, int tz, int ex, int ey, int ez, int rx, int ry, int rz, int rr, string endobj)
        {
            string sysDrive = System.Environment.GetEnvironmentVariable("SystemDrive") + @"\SVDMPRA\Sistema\";
            string filePath = Path.Combine(sysDrive, "svdmpra.cfg");
            Stream st = File.Open(filePath, FileMode.Append);
            StreamWriter s = new StreamWriter(st);
            s.WriteLine("#objeto" + contador +"");
            s.WriteLine("marker objeto"+contador+" "+"single;" + marcador + ";80;0;0");//Validar Alguma maneira de buscar isso no banco apontamento de marcador
            s.WriteLine("");
            s.WriteLine("#Orientação Fisica do Objeto");
            //Para cada objeto essa orientação podera variar
            //Bolar alguma forma de cadastrar essa orientação(por um banco de dados por exemplo
            //ou configurar o objeto para ele ficar pronto ja cadastrado
            s.WriteLine("#Traslação x y z");
            s.WriteLine("translate objeto" + contador + " " + tx + " " + ty + " " + tz);
            s.WriteLine("#Escala x y z");
            s.WriteLine("scale objeto" +     contador + " " + ex + " " + ey + " " + ez);
            s.WriteLine("#Rotação x y z r");
            s.WriteLine("#rotate objeto" +    contador + " " + rx + " " + ry + " " + rz + " " + rr);
            s.WriteLine("#Endereço do Objeto");
            s.WriteLine("model objeto" +     contador + " " + endobj);//recuperar a localização do objeto pelo banco 
            s.WriteLine("");            
            s.Close();
        }
        public void ChamaRA()
        {
            string app = @"osgartviewer.exe";
            Process myProcess = System.Diagnostics.Process.Start(app);
            myProcess.WaitForExit();
        }
    }
}