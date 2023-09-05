using System.Reflection;

namespace Pizza
{
    public partial class MainForm : Form
    {
        public string default_browser = Properties.Settings.Default.app_default_browser;
        public const string datafile = "pizzajoints.csv"; // Holds our list of pizza joints
        public const int target_height = 480;
        public const int initial_top = 30;
        public int current_top = 30;

        public EditListForm editdialog = new EditListForm();

        public List<pizzajoint_template> pizzajoints = new List<pizzajoint_template>();

        public List<ToolStripMenuItem> browser_list = new List<ToolStripMenuItem>();
        public Dictionary<ToolStripMenuItem, string> browser_text = new Dictionary<ToolStripMenuItem, string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region add_browsers
            add_browser(braveToolStripMenuItem, "brave.exe");
            add_browser(chromeToolStripMenuItem, "chrome.exe");
            add_browser(iExplorerToolStripMenuItem, "iexplore.exe");
            add_browser(firefoxToolStripMenuItem, "firefox.exe");
            #endregion

            #region check_list
            // We're going to check if there is a .csv present. If not, we extract the default one,
            if (!File.Exists(datafile))
            {
                try
                {
                    File.WriteAllText(datafile, "Dominos,https://www.dominos.com/en/restaurants,https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Dominos_pizza_logo.svg/1200px-Dominos_pizza_logo.svg.png\r\nPapa Johns,https://www.papajohns.com/order/stores-near-me,https://1000logos.net/wp-content/uploads/2023/04/Papa-Johns-Logo-1994.png\r\nPizza Hut,https://www.pizzahut.com/,https://1000logos.net/wp-content/uploads/2023/04/Pizza-Hut-Logo-2010.png");
                }
                catch (Exception ex)
                {
                    Application.Exit();
                }
            }
            #endregion

            List<string> pizza_joints = File.ReadAllLines(datafile).ToList();
            foreach (string expected_pizzajoint in pizza_joints)
            {
                string[] pizzajoint_data = expected_pizzajoint.Split(','); // comma-delimiter
                if (pizzajoint_data.Length == 3)
                {
                    pizzajoint_template newjoint = new pizzajoint_template(pizzajoint_data[0], pizzajoint_data[1], pizzajoint_data[2]);
                    pizzajoints.Add(newjoint);
                    Button newbutton = newjoint.create_button(current_top);
                    current_top += 45;
                    this.Controls.Add(newbutton);
                }
                else
                {
                    // Bad data, do nothing
                }
            }
            int button_height = (pizzajoints.Count * 45);
            this.Height = (30 + button_height + 55);
            this.Location = new Point(this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);

        }

        public void handle_default_browser(ToolStripMenuItem clicked_item)
        {
            foreach (ToolStripMenuItem browser_button in browser_list)
            {
                if (browser_button != clicked_item)
                {
                    browser_button.Checked = false;
                }
                else
                {
                    browser_button.Checked = true;
                    Properties.Settings.Default.app_default_browser = browser_text[clicked_item];
                    Properties.Settings.Default.Save();
                }
            }

        }

        public void add_browser(ToolStripMenuItem menuitem, string process_string)
        {
            if (process_string.Equals(default_browser, StringComparison.OrdinalIgnoreCase))
            {
                menuitem.Checked = true;
            }
            else
            {
                menuitem.Checked = false;
            }
            browser_list.Add(menuitem);
            browser_text.Add(menuitem, process_string);
        }

        private void firefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_default_browser(this.firefoxToolStripMenuItem);
        }

        private void braveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_default_browser(this.braveToolStripMenuItem);
        }

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_default_browser(this.chromeToolStripMenuItem);
        }

        private void iExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_default_browser(this.iExplorerToolStripMenuItem);
        }

        private void modifyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editdialog.ShowDialog();
        }
    }
}