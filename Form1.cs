using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace W13___Senin
{
    public partial class Form_Ngedit : Form
    {
        private void DataMantap()
        {
            dtp_BirthDate.Value = Convert.ToDateTime(Data.Rows[posisi][2]);
            txt_playerID.Text = Data.Rows[posisi][0].ToString();
            txt_PlayerName.Text = Data.Rows[posisi][1].ToString();
            cb_Nationality.DisplayMember = Data.Rows[posisi][3].ToString();
            cb_Team.DisplayMember = Data.Rows[posisi][4].ToString();
            num_TeamNumber.Value = Convert.ToInt16(Data.Rows[posisi][5]);
        }
        public Form_Ngedit()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter mySqlAdapter;
        public string sqlQuery;
        public DataTable Data = new DataTable();
        public DataTable Available = new DataTable();
        public DataTable Nationality = new DataTable();
        public DataTable namaTeam = new DataTable();
        public string SelectedValue = "";
        public int posisi = 0;
        public int posisiAwal = 0;
        public int posisiAkhir = 0;
        
           
            
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "select p.player_id, p.player_name, p.birthdate, n.nation, t.team_name, p.team_number, t.team_id, n.nationality_id from player p, team t, nationality n where p.nationality_id = n.nationality_id and p.team_id = t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            mySqlAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlAdapter.Fill(Data);

            DataMantap();

            sqlQuery = "select nation, nationality_id from nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            mySqlAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlAdapter.Fill(Nationality);
            cb_Nationality.DataSource = Nationality;
            cb_Nationality.ValueMember = "nationality_id";
            cb_Nationality.DisplayMember = "nation";
            cb_Nationality.SelectedValue = Data.Rows[posisi][4].ToString();

            
            sqlQuery = "select  team_name, team_id from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            mySqlAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlAdapter.Fill(namaTeam);
            cb_Team.DataSource = namaTeam;
            cb_Team.ValueMember = "team_id";
            cb_Team.DisplayMember = "team_name";
            cb_Team.SelectedValue = Data.Rows[posisi][6].ToString();
            SelectedValue = cb_Team.SelectedValue.ToString();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Team_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_Nationality_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            posisi++;
            if (posisi > Data.Rows.Count-1)
            {
                posisi = posisi -1;
                DataMantap();
                MessageBox.Show("Data sudah paling akhir!");
            }
            else
            {
                DataMantap();
            }
            SelectedValue = cb_Team.SelectedValue.ToString();
        }
        private void btn_Prev_Click(object sender, EventArgs e)
        {
            posisi--;
            if(posisi < 0)
            {
                posisi = posisi +1;
                DataMantap();
                MessageBox.Show("Data sudah paling awal!");
            }
            else
            {
                DataMantap();
            }
            SelectedValue = cb_Team.SelectedValue.ToString();
        }
        private void btn_PrevAll_Click(object sender, EventArgs e)
        {
                posisi = 0;
                DataMantap();
                posisiAwal = posisiAwal + 1;

            if (posisiAwal > 1)
            {
                MessageBox.Show("Data sudah paling awal!");
                posisiAwal = 0;
            }
               
            
            SelectedValue = cb_Team.SelectedValue.ToString();
        }
        private void btn_NextAll_Click(object sender, EventArgs e)
        {
           
            posisi = Data.Rows.Count - 1;
            DataMantap();
            posisiAkhir = posisiAkhir + 1;

            if (posisiAkhir > 1)
            {
                MessageBox.Show("Data sudah paling akhir!");
                posisiAkhir = 0;
            }


            SelectedValue = cb_Team.SelectedValue.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (lbl_Available.Text == "Not Available")
            {
                MessageBox.Show("Team Number sudah ada!");
            }
            else
            {
                sqlQuery = $"update player set team_number = '{num_TeamNumber.Value.ToString()}', player_name = '{txt_PlayerName.Text}', nationality_id = '{cb_Nationality.SelectedValue.ToString()}', birthdate = '{dtp_BirthDate.Value.ToString("yyyMMdd")}', team_id = '{cb_Team.SelectedValue.ToString()}' where player_id = '{txt_playerID.Text}'";
                
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                
                MessageBox.Show($"Data Player dengan nama {txt_PlayerName.Text} sudah diupdate.");
            }
        }

        private void num_TeamNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable teamNum = new DataTable();
                string simpanID = SelectedValue;
                
                sqlQuery = $"select p.player_name as `Name`, p.team_number as `Number` from team t, player p where p.team_id = t.team_id and t.team_id = '{simpanID}' having p.team_number = {num_TeamNumber.Value.ToString()}";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                mySqlAdapter = new MySqlDataAdapter(sqlCommand);
                mySqlAdapter.Fill(teamNum);

                if(teamNum.Rows.Count == 0)
                {
                    lbl_Available.Text = "Available";
                }
                else
                {
                    lbl_Available.Text = "Not Available";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terdapat error dengan: \n" + ex.Message);
            }
        }
    }
}
