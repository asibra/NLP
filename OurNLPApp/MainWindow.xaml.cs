using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using edu.stanford.nlp.ie.crf;


namespace OurNLPApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
        OleDbDataAdapter adapter;
        OleDbDataAdapter adapter2;

        public MainWindow()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "PROVIDER = Microsoft.ACE.OLEDB.12.0; Data Source = Database.accdb";
            InitializeComponent();

            textb1.Text = @"    They were taken by the protectors of Kronos. The GAStech getting together with was infiltrated by POK users posing as caterers. POK users who worked for GAStech were able to organise this as they were involved in the organization of the catering for the event. These employees may have been involved with the Asterian people’s army, a paramilitary organization involved in the drugs trade as indicated by the contamination of the GAStech computers with a virus that produces Asterian People's Army themed spam ( using their magazine title “ARISE”). 

    The employees have been kidnapped, but not by the POK. The Asterian Peoples Army (APA) traffics drugs and Carmine Bodr0gi sold drugs for them and was arrested. His relative Loreto Bodrogi, may have been susceptible to compromising himself and his colleagues due to criminal pressure ( due to the arrest), and supplied the APA with the necessary information to organise the kidnapping and also access to GAStech computer system. The computers of the GAStech employee who appear to have been sending pro Kronos defence messages, have been deliberately infected with a virus to create them appear to be POK sympathizers a complete week prior to the kidnap. The motive is ransom for profit purely.";
            textb2.Text = @"    They were taken by the protectors of Kronos. The GAStech getting together with was infiltrated by POK users posing as caterers. POK users who worked for GAStech were able to organise this as they were involved in the organization of the catering for the event. These employees may have been involved with the Asterian people’s army, a paramilitary organization involved in the drugs trade as indicated by the contamination of the GAStech computers with a virus that produces Asterian People's Army themed spam ( using their magazine title “ARISE”).";
            textb3.Text = @"    The employees have been kidnapped, but not by the POK. The Asterian Peoples Army (APA) traffics drugs and Carmine Bodr0gi sold drugs for them and was arrested. His relative Loreto Bodrogi, may have been susceptible to compromising himself and his colleagues due to criminal pressure ( due to the arrest), and supplied the APA with the necessary information to organise the kidnapping and also access to GAStech computer system. The computers of the GAStech employee who appear to have been sending pro Kronos defence messages, have been deliberately infected with a virus to create them appear to be POK sympathizers a complete week prior to the kidnap. The motive is ransom for profit purely.";
            System.Data.DataTable dt = new System.Data.DataTable();
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM articles ORDER BY ID", conn);
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            myGrid.ItemsSource = dt.DefaultView;
            myGrid.Items.Refresh();

            dt = new System.Data.DataTable();
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM TheEvents ORDER BY TDate,Time", conn);
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            EventGrid.ItemsSource = dt.DefaultView;
            EventGrid.Items.Refresh();

            Persons PersonCard;

            System.Data.DataTable dt2 = new System.Data.DataTable();
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM ComboNames", conn);
            reader = cmd.ExecuteReader();
            int c = 1;
            while (reader.Read())
            {
                bool Isleader = false;
                PersonCard = new Persons();
                PersonCard.Name.Text = reader["PName"].ToString();
                PersonCard.Des.Text = reader["PNote"].ToString();
                if (reader["info"].ToString() == "leader")
                {
                    PersonCard.Leader.Visibility = Visibility.Visible;
                    PersonCard.POK.Visibility = Visibility.Visible;
                    Isleader = true;
                }
                if (reader["info"].ToString() == "POK")
                {
                    PersonCard.POK.Visibility = Visibility.Visible;                                            
                }
                
                if(reader["info"].ToString().Trim() != "")
                {
                    switch (c)
                    {
                        case 1:
                            Card1.Name.Text = reader["PName"].ToString();
                            Card1.Des.Text = reader["PNote"].ToString();
                            Card1.POK.Visibility = Visibility.Visible;
                            Card1.JTime = Convert.ToInt32(reader["JTime"]);
                            Card1.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card1.Leader.Visibility = Visibility.Visible;
                            break;
                        case 2:
                            Card2.Name.Text = reader["PName"].ToString();
                            Card2.Des.Text = reader["PNote"].ToString();
                            Card2.POK.Visibility = Visibility.Visible;
                            Card2.JTime = Convert.ToInt32(reader["JTime"]);
                            Card2.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card2.Leader.Visibility = Visibility.Visible;
                            break;
                        case 3:
                            Card3.Name.Text = reader["PName"].ToString();
                            Card3.Des.Text = reader["PNote"].ToString();
                            Card3.POK.Visibility = Visibility.Visible;
                            Card3.JTime = Convert.ToInt32(reader["JTime"]);
                            Card3.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card3.Leader.Visibility = Visibility.Visible;
                            break;
                        case 4:
                            Card4.Name.Text = reader["PName"].ToString();
                            Card4.Des.Text = reader["PNote"].ToString();
                            Card4.POK.Visibility = Visibility.Visible;
                            Card4.JTime = Convert.ToInt32(reader["JTime"]);
                            Card4.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card4.Leader.Visibility = Visibility.Visible;
                            break;
                        case 5:
                            Card5.Name.Text = reader["PName"].ToString();
                            Card5.Des.Text = reader["PNote"].ToString();
                            Card5.POK.Visibility = Visibility.Visible;
                            Card5.JTime = Convert.ToInt32(reader["JTime"]);
                            Card5.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card5.Leader.Visibility = Visibility.Visible;
                            break;
                        case 6:
                            Card6.Name.Text = reader["PName"].ToString();
                            Card6.Des.Text = reader["PNote"].ToString();
                            Card6.POK.Visibility = Visibility.Visible;
                            Card6.JTime = Convert.ToInt32(reader["JTime"]);
                            Card6.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card6.Leader.Visibility = Visibility.Visible;
                            break;
                        case 7:
                            Card7.Name.Text = reader["PName"].ToString();
                            Card7.Des.Text = reader["PNote"].ToString();
                            Card7.POK.Visibility = Visibility.Visible;                          
                            if (Isleader)
                                Card7.Leader.Visibility = Visibility.Visible;
                            break;
                        case 8:
                            Card8.Name.Text = reader["PName"].ToString();
                            Card8.Des.Text = reader["PNote"].ToString();
                            Card8.POK.Visibility = Visibility.Visible;
                            Card8.JTime = Convert.ToInt32(reader["JTime"]);
                            Card8.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card8.Leader.Visibility = Visibility.Visible;
                            break;
                        case 9:
                            Card9.Name.Text = reader["PName"].ToString();
                            Card9.Des.Text = reader["PNote"].ToString();
                            Card9.POK.Visibility = Visibility.Visible;
                            Card9.JTime = Convert.ToInt32(reader["JTime"]);
                            Card9.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card9.Leader.Visibility = Visibility.Visible;
                            break;
                        case 10:
                            Card10.Name.Text = reader["PName"].ToString();
                            Card10.Des.Text = reader["PNote"].ToString();
                            Card10.POK.Visibility = Visibility.Visible;
                            Card10.JTime = Convert.ToInt32(reader["JTime"]);
                            Card10.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card10.Leader.Visibility = Visibility.Visible;
                            break;
                        case 11:
                            Card11.Name.Text = reader["PName"].ToString();
                            Card11.Des.Text = reader["PNote"].ToString();
                            Card11.POK.Visibility = Visibility.Visible;
                            Card11.JTime = Convert.ToInt32(reader["JTime"]);
                            Card11.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card1.Leader.Visibility = Visibility.Visible;
                            break;
                        case 12:
                            Card12.Name.Text = reader["PName"].ToString();
                            Card12.Des.Text = reader["PNote"].ToString();
                            Card12.POK.Visibility = Visibility.Visible;
                            Card12.JTime = Convert.ToInt32(reader["JTime"]);
                            Card12.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card12.Leader.Visibility = Visibility.Visible;
                            break;
                        case 13:
                            Card13.Name.Text = reader["PName"].ToString();
                            Card13.Des.Text = reader["PNote"].ToString();
                            Card13.POK.Visibility = Visibility.Visible;
                            Card13.JTime = Convert.ToInt32(reader["JTime"]);
                            Card13.RTime = Convert.ToInt32(reader["RTime"]);
                            if (Isleader)
                                Card13.Leader.Visibility = Visibility.Visible;
                            break;
                    }
                    c++;
                }

                WPanel.Children.Add(PersonCard);
            }
            reader.Close();
            adapter2 = new OleDbDataAdapter(cmd);
            adapter2.Fill(dt2);
            conn.Close();

            combo.ItemsSource = dt2.DefaultView;
            combo.DisplayMemberPath = "PName";


        }

        private void ConvertBtn_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void LeaderQueryBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        void FindEvent()
        {
            bool isDateTime = false; ;
            conn.Open();
            cmd = new OleDbCommand("select * from JanuaryEvents ", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              
                var s1 = reader["TNote"].ToString();
                List<string> words = s1.Split(' ',',','.').ToList();

                string time="";
                foreach (var word in words)
                {
                    if (isDateTime)
                    {
                        OleDbCommand cmd2 = new OleDbCommand("insert into TheEvents Values(@D,@T,@E)", conn);
                        cmd2.Parameters.AddWithValue("@D", reader["TDate"]);

                        if(word == "AM" || word == "AM:" || word == "am")
                        {
                            cmd2.Parameters.AddWithValue("@T", time + " " + "AM");
                        } else if (word == "PM" || word == "PM:" || word == "pm")
                        {
                            cmd2.Parameters.AddWithValue("@T", time + " " + "PM");
                        } else
                        {
                            cmd2.Parameters.AddWithValue("@T", time);
                        }                            
                        cmd2.Parameters.AddWithValue("@E", reader["TNote"]);
                        cmd2.ExecuteNonQuery();
                    }

                    DateTime dateTime;
                    isDateTime = DateTime.TryParse(word, out dateTime);

                    if (isDateTime)
                    {
                        time = word;
                    }

                }
            }
            conn.Close();

        }

        private void FindNamesBtn_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Searchtextbox.Text.Trim() == "")
                Searchtextbox.Text = "-----";
            System.Data.DataTable dt = new System.Data.DataTable();
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM articles WHERE TNote Like @N1 OR TNote Like @N2 OR Subject Like @S ORDER BY ID", conn);
            cmd.Parameters.AddWithValue("N1", "%" + Searchtextbox.Text + "%");
            cmd.Parameters.AddWithValue("N2", "%" + combo.Text + "%");
            cmd.Parameters.AddWithValue("S", "%" + Searchtextbox.Text + "%");
            
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();

            myGrid.ItemsSource = dt.DefaultView;
            myGrid.Items.Refresh();
        }

        private void FindLeadersBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> Names = new List<string>();
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM ComboNames", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Names.Add(reader["PName"].ToString().Trim());
            }
            conn.Close();
            string text = "";
            foreach (string name in Names)
            {
                conn.Open();
                cmd = new OleDbCommand("SELECT TNote FROM articles_leaders_POK WHERE (((articles_leaders_POK.TNote) like  @N ))", conn);
                cmd.Parameters.AddWithValue("N", "% leader " + name + " %");
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    OleDbCommand cmd2 = new OleDbCommand("UPDATE ComboNames SET info=@In WHERE PName= @PN", conn);
                    cmd2.Parameters.AddWithValue("In", "leader");
                    cmd2.Parameters.AddWithValue("PN", name);
                    cmd2.ExecuteNonQuery();
                    text = text + name + "\n";
                }
                conn.Close();
            }
            MessageBox.Show(text);
        }



        private void TabItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void FindConnection_Click(object sender, RoutedEventArgs e)
        {
            ConnectionCard CC;

            List<string> NameList1 = new List<string>();
            List<string> NameList2 = new List<string>();

            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM ComboNames ORDER BY PName", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NameList1.Add(reader["PName"].ToString());
                NameList2.Add(reader["PName"].ToString());
            }
            conn.Close();
            foreach (var name1 in NameList1)
            {
                foreach(var name2 in NameList2)
                {
                    if(name1.ToString() != name2.ToString())
                    {
                        conn.Open();
                        cmd = new OleDbCommand("SELECT articles_leaders_POK.TNote FROM articles_leaders_POK WHERE (((articles_leaders_POK.TNote) Like @N1) AND ((articles_leaders_POK.TNote) Like @N2))", conn);
                        cmd.Parameters.AddWithValue("N1", "%" + name1.ToString() + "%");
                        cmd.Parameters.AddWithValue("N2", "%" + name2.ToString() + "%");
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Find Connection!");
                            CC = new ConnectionCard();
                            CC.Name1.Text = name1.ToString();
                            CC.Name2.Text = name2.ToString();
                            SPanel.Children.Add(CC);
                        }
                        conn.Close();
                    }
                }
            }
            
            MessageBox.Show("Done!");
        }

        private void TimeBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            DateTextBox.Content = $"Date: \nYear {Convert.ToInt32(Slider1.Value)}";

            if (Card1.JTime <= Slider1.Value && Card1.RTime > Slider1.Value)
            {
                Card1.Visibility = Visibility.Visible;
                P1.Visibility = Visibility.Visible;
            }
            else
            {
                Card1.Visibility = Visibility.Hidden;
                P1.Visibility = Visibility.Hidden;
            }

            if (Card2.JTime <= Slider1.Value && Card2.RTime > Slider1.Value)
            {
                Card2.Visibility = Visibility.Visible;
                P2.Visibility = Visibility.Visible;
            }
            else
            {
                Card2.Visibility = Visibility.Hidden;
                P2.Visibility = Visibility.Hidden;
            }

            if (Card3.JTime <= Slider1.Value && Card3.RTime > Slider1.Value)
            {
                Card3.Visibility = Visibility.Visible;
                P3.Visibility = Visibility.Visible;
            }
            else
            {
                Card3.Visibility = Visibility.Hidden;
                P3.Visibility = Visibility.Hidden;
            }

            if (Card4.JTime <= Slider1.Value && Card4.RTime > Slider1.Value)
            {
                Card4.Visibility = Visibility.Visible;
                P4.Visibility = Visibility.Visible;
            }
            else
            {
                Card4.Visibility = Visibility.Hidden;
                P4.Visibility = Visibility.Hidden;
            }

            if (Card5.JTime <= Slider1.Value && Card5.RTime > Slider1.Value)
            {
                Card5.Visibility = Visibility.Visible;
                P5.Visibility = Visibility.Visible;
            }
            else
            {
                Card5.Visibility = Visibility.Hidden;
                P5.Visibility = Visibility.Hidden;
            }

            if (Card6.JTime <= Slider1.Value && Card6.RTime > Slider1.Value)
            {
                Card6.Visibility = Visibility.Visible;
                P6.Visibility = Visibility.Visible;
            }
            else
            {
                Card6.Visibility = Visibility.Hidden;
                P6.Visibility = Visibility.Hidden;
            }

            if (Card7.JTime <= Slider1.Value && Card7.RTime > Slider1.Value)
            {
                Card7.Visibility = Visibility.Visible;
                P7.Visibility = Visibility.Visible;
            }
            else
            {
                Card7.Visibility = Visibility.Hidden;
                P7.Visibility = Visibility.Hidden;
            }

            if (Card8.JTime <= Slider1.Value && Card8.RTime > Slider1.Value)
            {
                Card8.Visibility = Visibility.Visible;
                P8.Visibility = Visibility.Visible;
            }
            else
            {
                Card8.Visibility = Visibility.Hidden;
                P8.Visibility = Visibility.Hidden;
            }

            if (Card9.JTime <= Slider1.Value && Card9.RTime > Slider1.Value)
            {
                Card9.Visibility = Visibility.Visible;
                P9.Visibility = Visibility.Visible;
            }
            else
            {
                Card9.Visibility = Visibility.Hidden;
                P9.Visibility = Visibility.Hidden;
            }

            if (Card10.JTime <= Slider1.Value && Card10.RTime > Slider1.Value)
            {
                Card10.Visibility = Visibility.Visible;
                P10.Visibility = Visibility.Visible;
            }
            else
            {
                Card10.Visibility = Visibility.Hidden;
                P10.Visibility = Visibility.Hidden;
            }

            if (Card11.JTime <= Slider1.Value && Card11.RTime > Slider1.Value)
            {
                Card11.Visibility = Visibility.Visible;
                P11.Visibility = Visibility.Visible;
            }
            else
            {
                Card11.Visibility = Visibility.Hidden;
                P11.Visibility = Visibility.Hidden;
            }

            if (Card12.JTime <= Slider1.Value && Card12.RTime > Slider1.Value)
            {
                Card12.Visibility = Visibility.Visible;
                P12.Visibility = Visibility.Visible;
            }
            else
            {
                Card12.Visibility = Visibility.Hidden;
                P12.Visibility = Visibility.Hidden;
            }

            if (Card13.JTime <= Slider1.Value && Card13.RTime > Slider1.Value)
            {
                Card13.Visibility = Visibility.Visible;
                P13.Visibility = Visibility.Visible;
            }
            else
            {
                Card13.Visibility = Visibility.Hidden;
                P13.Visibility = Visibility.Hidden;
            }
            if(Convert.ToInt32(Slider1.Value) < 1997)
            {
                DateTextBox.Content = "Date: \nAll years";
                Card1.Visibility = Visibility.Visible;
                Card2.Visibility = Visibility.Visible;
                Card3.Visibility = Visibility.Visible;
                Card4.Visibility = Visibility.Visible;
                Card5.Visibility = Visibility.Visible;
                Card6.Visibility = Visibility.Visible;
                Card7.Visibility = Visibility.Visible;
                Card8.Visibility = Visibility.Visible;
                Card9.Visibility = Visibility.Visible;
                Card10.Visibility = Visibility.Visible;
                Card11.Visibility = Visibility.Visible;
                Card12.Visibility = Visibility.Visible;
                Card13.Visibility = Visibility.Visible;
                P1.Visibility = Visibility.Visible;
                P2.Visibility = Visibility.Visible;
                P3.Visibility = Visibility.Visible;
                P4.Visibility = Visibility.Visible;
                P5.Visibility = Visibility.Visible;
                P6.Visibility = Visibility.Visible;
                P7.Visibility = Visibility.Visible;
                P8.Visibility = Visibility.Visible;
                P9.Visibility = Visibility.Visible;
                P10.Visibility = Visibility.Visible;
                P11.Visibility = Visibility.Visible;
                P12.Visibility = Visibility.Visible;
                P13.Visibility = Visibility.Visible;
            }
        }

        private void EventBtn_Click(object sender, RoutedEventArgs e)
        {
            FindEvent();
        }


        private void EventGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType == typeof(System.DateTime) && e.PropertyName == "TDate")
            {
                (e.Column as DataGridTextColumn).Binding.StringFormat = "dd/MM/yyyy";
            }
            if (e.PropertyType == typeof(System.DateTime) && e.PropertyName == "Time")
            {
                (e.Column as DataGridTextColumn).Binding.StringFormat = "HH:mm tt";
            }

        }

        private void MyGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if(e.PropertyType == typeof(System.DateTime) && e.PropertyName == "TDate")
                (e.Column as DataGridTextColumn).Binding.StringFormat = "dd/MM/yyyy";
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < 845; i++)
            {
                string[] lines = System.IO.File.ReadAllLines($@"articles\{i}.txt");
                try
                {
                    conn.Open();
                    cmd = new OleDbCommand("Insert Into articles(ID) Values(@I)", conn);
                    cmd.Parameters.AddWithValue("I", i);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();
                }

                string text = "";
                bool Note = false;
                bool Source = true;
                bool Subject = false;
                bool isDateTime = false;
                bool name = false;
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        DateTime dateTime;
                        isDateTime = DateTime.TryParse(line, out dateTime);

                        if (name && !isDateTime)
                        {
                            name = false;
                            conn.Open();
                            cmd = new OleDbCommand("UPDATE articles SET TName = @Na WHERE ID = @I", conn);
                            cmd.Parameters.AddWithValue("Na", line);
                            cmd.Parameters.AddWithValue("I", i);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        if (Subject)
                        {
                            Subject = false;
                            conn.Open();
                            cmd = new OleDbCommand("UPDATE articles SET Subject = @S WHERE ID = @I", conn);
                            cmd.Parameters.AddWithValue("S", line);
                            cmd.Parameters.AddWithValue("I", i);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            name = true;
                        }



                        if (Source)
                        {
                            Source = false;
                            Subject = true;
                            conn.Open();
                            cmd = new OleDbCommand("UPDATE articles SET Source = @S WHERE ID = @I", conn);
                            cmd.Parameters.AddWithValue("S", line);
                            cmd.Parameters.AddWithValue("I", i);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        if (Note)
                        {
                            text = text + line + " ";
                            conn.Open();
                            cmd = new OleDbCommand("UPDATE articles SET TNote = @N WHERE ID = @I", conn);
                            cmd.Parameters.AddWithValue("N", text);
                            cmd.Parameters.AddWithValue("I", i);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }


                        if (isDateTime)
                        {
                            name = false;
                            conn.Open();
                            cmd = new OleDbCommand("UPDATE articles SET TDate = @date WHERE ID = @I", conn);
                            cmd.Parameters.AddWithValue("date", line);
                            cmd.Parameters.AddWithValue("I", i);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            Note = true;
                        }
                    }

                }
            }
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            TextToDB.Fill = new SolidColorBrush(Color.FromArgb(50, 0, 0, 0));
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            TextToDB.Fill= new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void Rectangle_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            conn.Open();
            cmd = new OleDbCommand(@"SELECT articles.ID, articles.TName, articles.TDate, articles.Source, articles.Subject, articles.TNote 
                                    INTO articles_leaders_POK FROM articles WHERE (((articles.TNote) Like @L)) OR (((articles.TNote) Like @P));", conn);
            cmd.Parameters.AddWithValue("L", "%leader%");
            cmd.Parameters.AddWithValue("P", "%POK%");
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Grid_MouseEnter_1(object sender, MouseEventArgs e)
        {
            RemoveRecord.Fill = new SolidColorBrush(Color.FromArgb(50, 0, 0, 0));
        }

        private void Grid_MouseLeave_1(object sender, MouseEventArgs e)
        {
            RemoveRecord.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void Rectangle_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            var jarRoot = @"D:\stanford-ner-2018-10-16";
            var classifiersDirecrory = jarRoot + @"\classifiers";

            // Loading 3 class classifier model
            var classifier = CRFClassifier.getClassifierNoExceptions(
                classifiersDirecrory + @"\english.all.3class.distsim.crf.ser.gz");

            conn.Open();
            cmd = new OleDbCommand("SELECT * From articles", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var s1 = reader["TNote"].ToString();
                var s2 = classifier.classifyWithInlineXML(s1);
                List<string> words = s2.Split(' ', ',', '<', '>').ToList();
                List<string> person = new List<string>();
                int count = 0;
                int count1 = 0;
                bool isTagPerson = false;
                foreach (var word in words)
                {
                    if (word == "/PERSON")
                    {
                        isTagPerson = false;
                        count1 += 1;
                    }

                    if (isTagPerson)
                        person[count1] = person[count1] + word + " ";
                    if (word == "PERSON")
                    {
                        isTagPerson = true;
                        person.Add("");
                    }


                    count += 1;
                }

                for (int i = 0; i < count1; i++)
                {
                    OleDbCommand cmd2 = new OleDbCommand("Insert Into AllNames(PName) Values(@PN)", conn);
                    cmd2.Parameters.AddWithValue("PN", person[i]);
                    cmd2.ExecuteNonQuery();
                }
            }
            conn.Close();
        }

        private void Grid_MouseEnter_2(object sender, MouseEventArgs e)
        {
            FindNames.Fill = new SolidColorBrush(Color.FromArgb(50, 0, 0, 0));
        }

        private void Grid_MouseLeave_2(object sender, MouseEventArgs e)
        {
            FindNames.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void Rectangle_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            List<string> NameList = new List<string>();

            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM ComboNames WHERE (((ComboNames.info) Like @I1) OR ((ComboNames.info) Like @I2)) ORDER BY PName", conn);
            cmd.Parameters.AddWithValue("I1", "%POK%");
            cmd.Parameters.AddWithValue("I2", "%leader%");
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NameList.Add(reader["PName"].ToString());
            }
            conn.Close();

            foreach (var name in NameList)
            {
                conn.Open();
                cmd = new OleDbCommand("SELECT articles_leaders_POK.TDate FROM articles_leaders_POK WHERE ((articles_leaders_POK.TNote) Like @N1)", conn);
                cmd.Parameters.AddWithValue("N1", "%" + name.ToString() + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OleDbCommand cmd2 = new OleDbCommand("INSERT INTO TimeLapseTable(PName,TDate) VALUES(@N,@D)", conn);
                    cmd2.Parameters.AddWithValue("N", name);
                    cmd2.Parameters.AddWithValue("D", reader["TDate"]);
                    cmd2.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void Grid_MouseEnter_3(object sender, MouseEventArgs e)
        {
            TimeLapse.Fill = new SolidColorBrush(Color.FromArgb(50, 0, 0, 0));
        }

        private void Grid_MouseLeave_3(object sender, MouseEventArgs e)
        {
            TimeLapse.Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void Rectangle_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            List<string> Names = new List<string>();
            conn.Open();
            cmd = new OleDbCommand("SELECT * FROM ComboNames", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Names.Add(reader["PName"].ToString().Trim());
            }
            conn.Close();
            string text = "";
            foreach (string name in Names)
            {
                conn.Open();
                cmd = new OleDbCommand("SELECT TNote FROM articles_leaders_POK WHERE (((articles_leaders_POK.TNote) like  @N ))", conn);
                cmd.Parameters.AddWithValue("N", "% leader " + name + " %");
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    OleDbCommand cmd2 = new OleDbCommand("UPDATE ComboNames SET info=@In WHERE PName= @PN", conn);
                    cmd2.Parameters.AddWithValue("In", "leader");
                    cmd2.Parameters.AddWithValue("PN", name);
                    cmd2.ExecuteNonQuery();
                    text = text + name + "\n";
                }
                conn.Close();
            }            
        }
    }
}
