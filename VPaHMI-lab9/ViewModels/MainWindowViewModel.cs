using System;
using System.Collections.Generic;
using System.Text;

namespace VPaHMI_lab9.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private FileReviewerViewModel? _files;

        public FileReviewerViewModel Files
        {
            get => _files ??= new FileReviewerViewModel();
        }
    }
}
