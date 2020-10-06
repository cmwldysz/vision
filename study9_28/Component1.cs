using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study9_28
{
    public partial class Component1 : Button
    {
        public Component1()
        {
            InitializeComponent();
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        //枚举类型 -> 指示图片类型
        enum ButtonPressImage { 
            None,
            Up,
            down,
            Left,
            Right
        }
        //派生出枚举字段
        private ButtonPressImage buttonType;

        private ButtonPressImage ButtonType { 
            get{
                return ButtonType;
            }
            set { 
                buttonType = value;
                switch (buttonType)
                {
                    case ButtonPressImage.None:
                        break;
                    case ButtonPressImage.Up:
                        break;
                    case ButtonPressImage.down:
                        break;
                    case ButtonPressImage.Left:
                        break;
                    case ButtonPressImage.Right:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
