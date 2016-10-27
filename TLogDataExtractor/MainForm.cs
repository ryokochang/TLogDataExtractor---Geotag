//
// This program extracts data from the txt dump of an APM Mission Planner log file. The output
// data is stored as a comma separated value (CSV) file that can be opened in Excel. Note that it can't
// open the tlog file directly. You must use the Mission Planner to convert it to txt format.
//
// From the APM Mission Planner Flight Data page select "Telemetry Logs", then "Tlog > Kml or Graph", then "Convert to Text".
// Select the tlog file you are interested in, and the Mission Planner will create a txt file in its log folder.
// 
// Open the txt file in this program and it will parse the file and list the available parameters. Double click on the parameters you
// are interested in and they will be selected. "Save As" and provide an output file name. That's it.
//
//


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.FileIO;
using System.Threading;

namespace TLogDataExtractor
{


    public partial class MainForm : Form
    {
        string configurationFileName;
        string inputFileName;
        string outputFileName;
        string path_File;
        string path_Folder;
        string[] arquivos;

        StreamReader inputFile;
        StreamReader configurationFileIn;
        StreamWriter configurationFileOut;
        StreamWriter outputFile;

        class ParameterDefinition
        {
            public string packetName;
            public string parameterName;
            public double value;

            public ParameterDefinition(string pktName, string paramName, double val)
            {
                this.packetName = pktName;
                this.parameterName = paramName;
                this.value = val;
            }
        }


        List<ParameterDefinition> parameterList = new List<ParameterDefinition>();
        List<ParameterDefinition> inputFileParameterList = new List<ParameterDefinition>();

        
        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String inputLine;

            string packetType = "";
            string[] inputLineSplit;
            bool foundPacketType;
            bool addNodes;
            bool newPacketType = false;
            bool param_type = true;


            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Documents (*.txt)|*.txt|All Files|*.*";
            dlg.ShowDialog();
            inputFileName = dlg.FileName;
            TreeNode tnPacketNode = null;
            if (File.Exists(inputFileName))
            {
                inputFile = new StreamReader(inputFileName);
                inputLine = inputFile.ReadLine();

                while (inputLine != null)
                {
                    inputLineSplit = inputLine.Split(' ');

                    foundPacketType = false;
                    addNodes = false;

                    param_type = false;

                    foreach (string field in inputLineSplit)
                    {
                        if (!foundPacketType)
                        {
                            if (field.Contains("mavlink_"))
                            {
                                foundPacketType = true;
                                packetType = field;

                                newPacketType = true;

                                foreach (TreeNode tnPacket in fileParametersTree.Nodes)
                                {
                                    if (String.Compare(tnPacket.Text, packetType, true) == 0)
                                        newPacketType = false;
                                }

                            }

                        }

                        if (newPacketType == true)
                        {
                            tnPacketNode = fileParametersTree.Nodes.Add(packetType);
                            newPacketType = false;
                            addNodes = true;
                        }

                        if (addNodes && (field.Length > 0))
                        {
                            if (param_type)
                            {
                                tnPacketNode.Nodes.Add(field);
                            }

                            param_type = !param_type;

                        }
                    }

                    inputLine = inputFile.ReadLine();
                }

                inputFile.Close();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        // SaveAs parses the input file extracts the desires parameters, amd saves them in a CSV (comma separated values) format text file
        //
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String inputLine;
            int parameterIndexInString;
            bool parameterInString;
            int parameterEnd;
            String parameterValue;
            string[] inputLineSplit;

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Comma Separated Values Documents (*.csv)|*.csv|All Files|*.*";
            dlg.ShowDialog();
            outputFileName = dlg.FileName;
            if (outputFileName != "")
            {
                outputFile = new StreamWriter(outputFileName);
                inputFile = new StreamReader(inputFileName);

                //
                // Output the header row
                //
                outputFile.Write("Date; Time");         // start with the Date and Time fields

                foreach (TreeNode tn in selectedParametersTree.Nodes)       // then each of the selected parameters
                {
                    foreach (TreeNode tpn in tn.Nodes)
                    {
                        outputFile.Write("; {0}.{1}", tn.Text, tpn.Text);   // format is PacketName.ParameterName
                    }
                }
                outputFile.WriteLine();


                //
                // Parse each line in the input file
                //
                inputLine = inputFile.ReadLine();
                while (inputLine != null)
                {
                    parameterInString = false;

                    inputLineSplit = inputLine.Split(' ');

                    // search in each line for the packet name of each of the selected parameters
                    foreach (TreeNode tn in selectedParametersTree.Nodes)
                    {
                        if (inputLine.Contains(tn.Text))
                        {
                            // if the packet name was found, search the line for each parameter 
                            foreach (TreeNode tpn in tn.Nodes)
                            {
                                parameterIndexInString = inputLine.IndexOf(tpn.Text);

                                if (parameterIndexInString != -1)
                                {
                                    parameterIndexInString = parameterIndexInString + tpn.Text.Length + 1;   // Skip parameter name + 1 for the " " between the parameter name and the value
                                    parameterEnd = inputLine.IndexOf(' ', parameterIndexInString);
                                    parameterValue = inputLine.Substring(parameterIndexInString, parameterEnd - parameterIndexInString);
                                    tpn.Tag = parameterValue;
                                    parameterInString = true;
                                }
                            }
                        }
                    }

                    // 
                    // If at least parameter was found, write them all to the output file.
                    if (parameterInString)
                    {
                        outputFile.Write("{0}; {1} ", inputLineSplit[0], inputLineSplit[1]);         // Date and time fields

                        foreach (TreeNode tn in selectedParametersTree.Nodes)
                        {
                            foreach (TreeNode tpn in tn.Nodes)
                            {
                                outputFile.Write("; {0}", tpn.Tag);
                            }
                        }
                        outputFile.WriteLine("");
                    }

                    inputLine = inputFile.ReadLine();
                }

                outputFile.Close();
                inputFile.Close();
            }
        }
        //
        // Load a file containing a list of parameters
        //
        private void loadParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strLine;
            char[] separators = new char[] { ' ', ';' };
            string[] parts;
            bool newPacketType;
            bool newParamType;
            TreeNode tnPacketNode = null;
            TreeNode tnParamNode = null;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Parameter files (*.param)|*.param|All Files|*.*";
            dlg.ShowDialog();
            configurationFileName = dlg.FileName;
            if (File.Exists(configurationFileName))
            {
                configurationFileIn = new StreamReader(configurationFileName);

                strLine = configurationFileIn.ReadLine();

                while (strLine != null)
                {
                    parts = strLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    newPacketType = true;

                    foreach (TreeNode tn in selectedParametersTree.Nodes)
                    {
                        if (String.Compare(tn.Text, Convert.ToString(parts[0]), true) == 0)
                        {
                            tnPacketNode = tn;
                            newPacketType = false;
                        }
                    }

                    if (newPacketType == true)
                        tnPacketNode = selectedParametersTree.Nodes.Add(Convert.ToString(parts[0]));

                    newParamType = true;

                    foreach (TreeNode tpn in tnPacketNode.Nodes)
                    {
                        if (String.Compare(tpn.Text, Convert.ToString(parts[1]), true) == 0)
                        {
                            tnParamNode = tpn;
                            newParamType = false;
                        }
                    }

                    if (newParamType == true)
                    {
                        tnParamNode = tnPacketNode.Nodes.Add(Convert.ToString(parts[1]));
                        tnParamNode.Tag = 0;
                    }

                    strLine = configurationFileIn.ReadLine();
                }

                configurationFileIn.Close();
            }
        }

        // 
        // Save the list of selected parameters
        //
        private void saveParameterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Parameter files (*.param)|*.param|All Files|*.*";
            dlg.ShowDialog();
                if (dlg.FileName != "")
                {
                        configurationFileOut = new StreamWriter(dlg.FileName);

                        foreach (TreeNode tn in selectedParametersTree.Nodes)
                        {
                            foreach (TreeNode tpn in tn.Nodes)
                            {
                                configurationFileOut.WriteLine("{0} {1}", tn.Text, tpn.Text);
                            }
                        }

                        configurationFileOut.Close();
                }
            }

        //
        // Responds to the user double-clicking in the input file parameter list by adding the parameter to the output file list
        //
        private void fileParametersTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode tnPacketNode=null;
            TreeNode tnParamNode;
            bool newPacketType;
            bool newParamType;

            TreeNode tnPacket = fileParametersTree.SelectedNode.Parent;

            if(tnPacket!=null)
            {

                // Check for repeat
                newPacketType = true;

                foreach (TreeNode tn in selectedParametersTree.Nodes)
                {
                    if (String.Compare(tn.Text, tnPacket.Text, true) == 0)
                    {
                        tnPacketNode = tn;
                        newPacketType = false;
                    }
                }

                if (newPacketType == true)
                     tnPacketNode = selectedParametersTree.Nodes.Add(tnPacket.Text);

                newParamType = true;

                foreach (TreeNode tpn in tnPacketNode.Nodes)
                {
                    if (String.Compare(tpn.Text, fileParametersTree.SelectedNode.Text, true) == 0)
                    {
                        tnParamNode = tpn;
                        newParamType = false;
                    }
                }

                if (newParamType == true)
                {
                    tnParamNode = tnPacketNode.Nodes.Add(fileParametersTree.SelectedNode.Text);
                    tnParamNode.Tag = 0.0;
                }
            }
        }

        //
        // Responds to the user double-clicking in the output file parameter list by removing that parameter from the list
        //
        private void selectedParametersTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode tnPacket = selectedParametersTree.SelectedNode.Parent;

            if (tnPacket != null)
            {
                selectedParametersTree.SelectedNode.Remove();
                if (tnPacket.Nodes.Count == 0)
                    tnPacket.Remove();
            }
 
        }

        private void fileParametersTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void geoTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_geo.Visible = true;
            panel_extract.Visible = false;
        }

        private void extratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_extract.Visible = true;
            panel_geo.Visible = false;
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Logs|*.csv";
            openFileDialog1.ShowDialog();

            if (File.Exists(openFileDialog1.FileName))
            {
                textBox_log.Text = openFileDialog1.FileName;
                this.path_File = textBox_log.Text;
                textBox_output.AppendText("Arquivo .csv selecionado." + "\n");
            }
        }
        private void button_img_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(textBox_log.Text);
            }
            catch
            {
            }

            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath != "")
            {
                textBox_img.Text = folderBrowserDialog1.SelectedPath;
                this.path_Folder = textBox_img.Text;
                textBox_output.AppendText("Pasta selecionada." + "\n");
            }
        }
        private void button_Sync_Click(object sender, EventArgs e)
        {
            int nao_encontrados = 0;
            if (String.IsNullOrEmpty(path_File) || String.IsNullOrEmpty(path_Folder))
            {
                textBox_output.AppendText("Arquivos não selecionados." + "\n");
            }
            else
            {
                textBox_output.AppendText(path_Folder + "\n");
                textBox_output.AppendText(path_File + "\n");
                textBox_output.AppendText("\n");

                this.arquivos = Directory.GetFiles(path_Folder, "*.jpg", System.IO.SearchOption.TopDirectoryOnly);
                for (int i = 0; i < arquivos.Length; i++)
                {
                    FileInfo arquivos_inf = new FileInfo(arquivos[i]);
                    string criado = arquivos_inf.LastWriteTime.ToString("HH:mm:ss");
                    //textBox_output.AppendText(arquivos[i] +" "+ criado + "\n");
                    if (read_csv(arquivos[i], criado) == 0)
                    {
                        textBox_output.AppendText("Coordenadas não encontradas.\n");
                        nao_encontrados++;
                    }
                }
                textBox_output.AppendText("Total de arquivos não taggeados : " + nao_encontrados + "\n");
            }
        }

        //
        // Funções para geotagging
        //
        public void WriteCoordinatesToImage(string Filename, double dLat, double dLong, double alt)
        {
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(Filename)))
            {
                //TXT_outputlog.AppendText("GeoTagging " + Filename + "\n");
                //Application.DoEvents();

                byte[] balt = BitConverter.GetBytes(alt);

                using (Image Pic = Image.FromStream(ms))
                {
                    PropertyItem[] pi = Pic.PropertyItems;

                    pi[0].Id = 0x0004;
                    pi[0].Type = 5;
                    pi[0].Len = sizeof(ulong) * 3;
                    pi[0].Value = coordtobytearray(dLong);
                    Pic.SetPropertyItem(pi[0]);

                    pi[0].Id = 0x0002;
                    pi[0].Type = 5;
                    pi[0].Len = sizeof(ulong) * 3;
                    pi[0].Value = coordtobytearray(dLat);
                    Pic.SetPropertyItem(pi[0]);

                    pi[0].Id = 0x0006;
                    pi[0].Type = 5;
                    pi[0].Len = 8;
                    pi[0].Value = new Rational(alt).GetBytes();
                    Pic.SetPropertyItem(pi[0]);

                    pi[0].Id = 1;
                    pi[0].Len = 2;
                    pi[0].Type = 2;

                    if (dLat < 0)
                    {
                        pi[0].Value = new byte[] { (byte)'S', 0 };
                    }
                    else
                    {
                        pi[0].Value = new byte[] { (byte)'N', 0 };
                    }

                    Pic.SetPropertyItem(pi[0]);

                    pi[0].Id = 3;
                    pi[0].Len = 2;
                    pi[0].Type = 2;
                    if (dLong < 0)
                    {
                        pi[0].Value = new byte[] { (byte)'W', 0 };
                    }
                    else
                    {
                        pi[0].Value = new byte[] { (byte)'E', 0 };
                    }
                    Pic.SetPropertyItem(pi[0]);

                    // Save file into Geotag folder
                    string rootFolder = textBox_img.Text;
                    string geoTagFolder = rootFolder + Path.DirectorySeparatorChar + "geotagged";

                    string outputfilename = geoTagFolder + Path.DirectorySeparatorChar +
                                            Path.GetFileNameWithoutExtension(Filename) + "_geotag" +
                                            Path.GetExtension(Filename);

                    // Just in case
                    if (File.Exists(outputfilename))
                        File.Delete(outputfilename);

                    ImageCodecInfo ici = GetImageCodec("image/jpeg");
                    EncoderParameters eps = new EncoderParameters(1);
                    eps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);

                    Pic.Save(outputfilename);
                }
            }
        }

        public byte[] GetBytes(double input)
        {
            uint dem = 0;
            uint num = 0;
            byte[] answer = new byte[8];

            Array.Copy(BitConverter.GetBytes((uint)num), 0, answer, 0, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)dem), 0, answer, 4, sizeof(uint));

            return answer;
        }

        static ImageCodecInfo GetImageCodec(string mimetype)
        {
            foreach (ImageCodecInfo ici in ImageCodecInfo.GetImageEncoders())
            {
                if (ici.MimeType == mimetype) return ici;
            }
            return null;
        }

        public int read_csv(string file_path, string hour_created)
        {
            using (TextFieldParser parser = new TextFieldParser(path_File))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                int num_img = 0;
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] linha = parser.ReadFields();
                    int indice_hora = 1;
                    string hour = linha[indice_hora];

                    if (hour == hour_created)
                    {
                        for (int i = 1; i < linha.Length; i++)
                        {
                            textBox_output.AppendText(linha[i] + " ,");
                        }
                        textBox_output.AppendText("\n\n");

                        double lat = Convert.ToDouble(linha[2]);
                        double lon = Convert.ToDouble(linha[3]);
                        double alt = Convert.ToDouble(linha[4]);

                        lat = lat / (10000000.0);
                        lon = lon / (10000000.0);
                        alt = alt / (1000.0);

                        WriteCoordinatesToImage(file_path, lat, lon, alt);
                        return 1;
                    }

                    continue;
                }
                num_img++;
                return 0;
            }
        }

        private byte[] coordtobytearray(double coordin)
        {
            double coord = Math.Abs(coordin);

            byte[] output = new byte[sizeof(double) * 3];

            int d = (int)coord;
            int m = (int)((coord - d) * 60);
            double s = ((((coord - d) * 60) - m) * 60);
            /*
21 00 00 00 01 00 00 00--> 33/1
18 00 00 00 01 00 00 00--> 24/1
06 02 00 00 0A 00 00 00--> 518/10
*/

            Array.Copy(BitConverter.GetBytes((uint)d), 0, output, 0, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)1), 0, output, 4, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)m), 0, output, 8, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)1), 0, output, 12, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)(s * 1.0e7)), 0, output, 16, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)1.0e7), 0, output, 20, sizeof(uint));
            /*
            Array.Copy(BitConverter.GetBytes((uint)d * 1.0e7), 0, output, 0, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)1.0e7), 0, output, 4, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)0), 0, output, 8, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)1), 0, output, 12, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)0), 0, output, 16, sizeof(uint));
            Array.Copy(BitConverter.GetBytes((uint)1), 0, output, 20, sizeof(uint));
            */
            return output;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.ShowDialog();
        }
    }
}
