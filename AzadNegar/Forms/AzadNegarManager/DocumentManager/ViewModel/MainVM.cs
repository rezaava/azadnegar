using System;
using AzadNegar.Forms.AzadNegarManager.DocumentManager.Utilities;

namespace AzadNegar.Forms.AzadNegarManager.DocumentManager.ViewModel
{
    public class MainVM : ViewModelBase, IGoToDocumentManager
    {
        public Action GoToMain { get; set; }
        public Action GoToDocuments { get; set; }
        public Action GoToLogin { get; set; }

        public MainVM()
        {
        }
    }
}
