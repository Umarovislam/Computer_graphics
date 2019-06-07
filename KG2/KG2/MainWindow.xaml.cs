using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Data;
using System.Drawing.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KG2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // System.Drawing.Image ims;

        public MainWindow()
        {
            InitializeComponent();
            CreateDataTbale();
        }

        // Create a new DataTable.
        private System.Data.DataTable table = new DataTable("FileTable");
        // Declare variables for DataColumn and DataRow objects.
        private DataColumn column;
        private DataRow row;

        private void CreateDataTbale()
        {

            table.Columns.Add("Type ", typeof(string));
            table.Columns.Add("Width ", typeof(int));
            table.Columns.Add("Height ", typeof(int));
            table.Columns.Add("resolutions ", typeof(string));
            /*

             // Create second column.
             column = new DataColumn();
             column.DataType = System.Type.GetType("System.String");
             column.ColumnName = "ImageFormat";
             column.AutoIncrement = false;
             column.Caption = "Image Format";
             column.ReadOnly = false;
             column.Unique = false;
             // Add the column to the table.
             table.Columns.Add(column);
             //Create Third Column "WIDTH"
             column = new DataColumn();
             column.DataType = System.Type.GetType("System.String");
             column.ColumnName = "ImageWidth";
             column.AutoIncrement = false;
             column.Caption = "ImageWidth";
             column.ReadOnly = false;
             column.Unique = false;
             // Add the column to the table.
             table.Columns.Add(column);


             column = new DataColumn();
             column.DataType = System.Type.GetType("System.String");
             column.ColumnName = "ImageHeight";
             column.AutoIncrement = false;
             column.Caption = "ImageHeight";
             column.ReadOnly = false;
             column.Unique = false;
             // Add the column to the table.
             table.Columns.Add(column);


             column = new DataColumn();
             column.DataType = System.Type.GetType("System.String");
             column.ColumnName = "Imageresolution";
             column.AutoIncrement = false;
             column.Caption = "Imageresolution";
             column.ReadOnly = false;
             column.Unique = false;
             // Add the column to the table.
             table.Columns.Add(column);
             */

        }

        private void ImgInit(System.Drawing.Image image, ImageFormat format)
        {
            row = table.NewRow();
            row["ImageFormat"] = format.ToString();
            row["ImageWidth"] = image.Width;
            row["ImageHeight"] = image.Height;
            row["Imageresolution"] = "" + (image.VerticalResolution * image.HorizontalResolution);
            dgColumn.ItemsSource = table.DefaultView;
        }


        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Multiselect = true;
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|GIF Files (*.gif)|*.gif";
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                foreach(string item in dlg.FileNames)
                {
                   System.Drawing.Image img = System.Drawing.Image.FromFile(item);
                    ImageFormat format = img.RawFormat;

                    table.Rows.Add(format.ToString(), img.Width, img.Height, "" + +(img.VerticalResolution * img.HorizontalResolution));

                    /*row = table.NewRow();
                    row["ImageFormat"] = format.ToString();
                    row["ImageWidth"] = "" + img.Width;
                    row["ImageHeight"] = ""+ img.Height;
                    row["Imageresolution"] = "" + (img.VerticalResolution * img.HorizontalResolution);
                    dgColumn.ItemsSource = table.DefaultView;
                    */
                    dgColumn.ItemsSource = table.DefaultView;
                }
            }
        }
    }
}
