using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ContactList.Classes;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ContactList.User_Control {
    public sealed partial class ContactControl : UserControl {
        private Contact contact;
        
        public Contact Contact {
            get { return contact; }
            set {
                contact = value;
                lblFirstName.Text = contact.FirstName;
                lblLastName.Text = contact.LastName;
                lblAge.Text = contact.Age;
                lblEmail.Text = contact.Email;
            }
        }

        public ContactControl() {
            this.InitializeComponent();
        }


    }
}
