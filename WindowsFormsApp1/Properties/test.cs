using System.ComponentModel;

namespace WindowsFormsApp1.Properties
{
    public partial class test : Component
    {
        public test()
        {
            InitializeComponent();
        }

        public test(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}