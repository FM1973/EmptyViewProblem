using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace EmptyViewProblem
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<TestData> _list;

        public MainPageViewModel()
        {
            List = new ObservableCollection<TestData>();
        }
    }

    public class TestData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
