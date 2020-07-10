using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NodeWithImageDemo
{
    public class FileManager : INotifyPropertyChanged
    {
        private string fileName;
        private ImageSource imageIcon;
        private ObservableCollection<FileManager> subFiles;

        public ObservableCollection<FileManager> SubFiles
        {
            get { return subFiles; }
            set
            {
                subFiles = value;
                RaisedOnPropertyChanged("SubFiles");
            }
        }

        public string ItemName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisedOnPropertyChanged("FolderName");
            }
        }

        public ImageSource ImageIcon
        {
            get { return imageIcon; }
            set
            {
                imageIcon = value;
                RaisedOnPropertyChanged("ImageIcon");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }

}



























































































//        private string fileName;
//        private ImageSource imageIcon;
//        private ObservableCollection<FileManager> subFiles;

//        public ObservableCollection<FileManager> SubFiles
//        {
//            get { return subFiles; }
//            set
//            {
//                subFiles = value;
//                RaisedOnPropertyChanged("SubFiles");
//            }
//        }

//        public string ItemName
//        {
//            get { return fileName; }
//            set
//            {
//                fileName = value;
//                RaisedOnPropertyChanged("ItemName");
//            }
//        }

//        public ImageSource ImageIcon
//        {
//            get { return imageIcon; }
//            set
//            {
//                imageIcon = value;
//                RaisedOnPropertyChanged("ImageIcon");
//            }
//        }

//        public event PropertyChangedEventHandler PropertyChanged;

//        public void RaisedOnPropertyChanged(string _PropertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
//            }
//        }
//    }
//}
