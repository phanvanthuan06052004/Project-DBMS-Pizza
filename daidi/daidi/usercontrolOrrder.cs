using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daidi
{
    public partial class usercontrolOrrder : UserControl
    {
        public usercontrolOrrder()
        {
            InitializeComponent();
        }

        private void usercontrolOrrder_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi người dùng nhấn vào nút "Xóa"
            // Ví dụ: Hiển thị hộp thoại xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng đồng ý xóa, gửi sự kiện đến form cha để xử lý việc xóa sản phẩm
                OnRemoveButtonClick(EventArgs.Empty);
            }
        }

        public event EventHandler RemoveButtonClick;

        protected virtual void OnRemoveButtonClick(EventArgs e)
        {
            RemoveButtonClick?.Invoke(this, e);
        }
    }
}
