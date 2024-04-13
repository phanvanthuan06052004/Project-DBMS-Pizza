namespace daidi
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string ProductName
        {
            get => lblProduct.Text;
            set => lblProduct.Text = value;
        }

        public string Price
        {
            get => lblPrice.Text;
            set => lblPrice.Text = value;
        }

        public Image ProductImg
        {
            get => ptcProduct.Image;
            set => ptcProduct.Image = value;
        }

        public ComboBox ProductComboBox
        {
            set => cbnProduct.DataSource = value.DataSource;
        }

        public PictureBox ProductPictureBox // This property exposes ptcProduct
        {
            get => ptcProduct;
        }
    }
}

