using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using dataJson;

namespace _30hillsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            string json = @"[
                                 {
                                    ""id"": 1,
                                    ""firstName"": ""Paul"",
                                    ""surname"": ""Crowe"",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      2
                                    ]
                                    },
                                  {
                                    ""id"": 2,
                                    ""firstName"": ""Rob"",
                                    ""surname"": ""Fitz"",
                                    ""age"": 23,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      1,
                                      3
                                    ]
                                },
                                  {
                                    ""id"": 3,
                                    ""firstName"": ""Ben"",
                                    ""surname"": ""Carolan"",
                                    ""age"": 0 ,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      2,
                                      4,
                                      5,
                                      7
                                    ]
                                  },
                                  {
                                    ""id"": 4,
                                    ""firstName"": ""Victor"",
                                    ""surname"": "" "",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      3
                                    ]
                                  },
                                  {
                                    ""id"": 5,
                                    ""firstName"": ""Peter"",
                                    ""surname"": ""Mac"",
                                    ""age"": 29,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      3,
                                      6,
                                      11,
                                      10,
                                      7
                                    ]
                                  },
                                  {
                                    ""id"": 6,
                                    ""firstName"": ""John"",
                                    ""surname"": ""Barry"",
                                    ""age"": 18,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      5
                                    ]
                                  },
                                  {
                                    ""id"": 7,
                                    ""firstName"": ""Sarah"",
                                    ""surname"": ""Lane"",
                                    ""age"": 30,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      3,
                                      5,
                                      20,
                                      12,
                                      8
                                    ]
                                  },
                                  {
                                    ""id"": 8,
                                    ""firstName"": ""Susan"",
                                    ""surname"": ""Downe"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      7
                                    ]
                                  },
                                  {
                                    ""id"": 9,
                                    ""firstName"": ""Jack"",
                                    ""surname"": ""Stam"",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      12
                                    ]
                                  },
                                  {
                                    ""id"": 10,
                                    ""firstName"": ""Amy"",
                                    ""surname"": ""Lane"",
                                    ""age"": 24,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      5,
                                      11
                                    ]
                                  },
                                  {
                                    ""id"": 11,
                                    ""firstName"": ""Sandra"",
                                    ""surname"": ""Phelan"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      5,
                                      10,
                                      19,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 12,
                                    ""firstName"": ""Laura"",
                                    ""surname"": ""Murphy"",
                                    ""age"": 33,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      7,
                                      9,
                                      13,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 13,
                                    ""firstName"": ""Lisa"",
                                    ""surname"": ""Daly"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      12,
                                      14,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 14,
                                    ""firstName"": ""Mark"",
                                    ""surname"": ""Johnson"",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      13,
                                      15
                                    ]
                                  },
                                  {
                                    ""id"": 15,
                                    ""firstName"": ""Seamus"",
                                    ""surname"": ""Crowe"",
                                    ""age"": 24,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      14
                                    ]
                                  },
                                  {
                                    ""id"": 16,
                                    ""firstName"": ""Daren"",
                                    ""surname"": ""Slater"",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      18,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 17,
                                    ""firstName"": ""Dara"",
                                    ""surname"": ""Zoltan"",
                                    ""age"": 48,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      18,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 18,
                                    ""firstName"": ""Marie"",
                                    ""surname"": ""D"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      17
                                    ]
                                  },
                                  {
                                    ""id"": 19,
                                    ""firstName"": ""Catriona"",
                                    ""surname"": ""Long"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      11,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 20,
                                    ""firstName"": ""Katy"",
                                    ""surname"": ""Couch"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      7,
                                      11,
                                      12,
                                      13,
                                      16,
                                      17,
                                      19
                                    ]
                                  }
                                ]";

            List<People> listMembers = JsonConvert.DeserializeObject<List<People>>(json);
            List<People> novaLista = new List<People>();
            novaLista = loadDirectFrndID(int.Parse(txtBoxID.Text), listMembers);
            dgvLista.DataSource = novaLista;
        }

        public List<People> loadDirectFrndID(int id, List<People> list)
        {
            List<People> novaLista = new List<People>();
            int p;
            for (int i = 0; i < list[id - 1].friends.Count; i++)
            {
                p = list[id - 1].friends[i];
                People covek = findPeopleID(p, list);
                novaLista.Add(covek);
            }
            return novaLista;
        }

        public People findPeopleID(int id, List<People> list)
        {
            People covek = new People();
            foreach (var item in list)
            {
                if (item.id == id)
                {
                    covek.id = item.id;
                    covek.firstName = item.firstName;
                    covek.surname = item.surname;
                    covek.age = item.age;
                    covek.gender = item.gender;
                    break;
                }
            }
            return covek;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string json = @"[
                                 {
                                    ""id"": 1,
                                    ""firstName"": ""Paul"",
                                    ""surname"": ""Crowe"",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      2
                                    ]
                                    },
                                  {
                                    ""id"": 2,
                                    ""firstName"": ""Rob"",
                                    ""surname"": ""Fitz"",
                                    ""age"": 23,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      1,
                                      3
                                    ]
                                },
                                  {
                                    ""id"": 3,
                                    ""firstName"": ""Ben"",
                                    ""surname"": ""Carolan"",
                                    ""age"": 0 ,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      2,
                                      4,
                                      5,
                                      7
                                    ]
                                  },
                                  {
                                    ""id"": 4,
                                    ""firstName"": ""Victor"",
                                    ""surname"": "" "",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      3
                                    ]
                                  },
                                  {
                                    ""id"": 5,
                                    ""firstName"": ""Peter"",
                                    ""surname"": ""Mac"",
                                    ""age"": 29,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      3,
                                      6,
                                      11,
                                      10,
                                      7
                                    ]
                                  },
                                  {
                                    ""id"": 6,
                                    ""firstName"": ""John"",
                                    ""surname"": ""Barry"",
                                    ""age"": 18,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      5
                                    ]
                                  },
                                  {
                                    ""id"": 7,
                                    ""firstName"": ""Sarah"",
                                    ""surname"": ""Lane"",
                                    ""age"": 30,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      3,
                                      5,
                                      20,
                                      12,
                                      8
                                    ]
                                  },
                                  {
                                    ""id"": 8,
                                    ""firstName"": ""Susan"",
                                    ""surname"": ""Downe"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      7
                                    ]
                                  },
                                  {
                                    ""id"": 9,
                                    ""firstName"": ""Jack"",
                                    ""surname"": ""Stam"",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      12
                                    ]
                                  },
                                  {
                                    ""id"": 10,
                                    ""firstName"": ""Amy"",
                                    ""surname"": ""Lane"",
                                    ""age"": 24,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      5,
                                      11
                                    ]
                                  },
                                  {
                                    ""id"": 11,
                                    ""firstName"": ""Sandra"",
                                    ""surname"": ""Phelan"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      5,
                                      10,
                                      19,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 12,
                                    ""firstName"": ""Laura"",
                                    ""surname"": ""Murphy"",
                                    ""age"": 33,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      7,
                                      9,
                                      13,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 13,
                                    ""firstName"": ""Lisa"",
                                    ""surname"": ""Daly"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      12,
                                      14,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 14,
                                    ""firstName"": ""Mark"",
                                    ""surname"": ""Johnson"",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      13,
                                      15
                                    ]
                                  },
                                  {
                                    ""id"": 15,
                                    ""firstName"": ""Seamus"",
                                    ""surname"": ""Crowe"",
                                    ""age"": 24,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      14
                                    ]
                                  },
                                  {
                                    ""id"": 16,
                                    ""firstName"": ""Daren"",
                                    ""surname"": ""Slater"",
                                    ""age"": 28,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      18,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 17,
                                    ""firstName"": ""Dara"",
                                    ""surname"": ""Zoltan"",
                                    ""age"": 48,
                                    ""gender"": ""male"",
                                    ""friends"": [
                                      18,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 18,
                                    ""firstName"": ""Marie"",
                                    ""surname"": ""D"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      17
                                    ]
                                  },
                                  {
                                    ""id"": 19,
                                    ""firstName"": ""Catriona"",
                                    ""surname"": ""Long"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      11,
                                      20
                                    ]
                                  },
                                  {
                                    ""id"": 20,
                                    ""firstName"": ""Katy"",
                                    ""surname"": ""Couch"",
                                    ""age"": 28,
                                    ""gender"": ""female"",
                                    ""friends"": [
                                      7,
                                      11,
                                      12,
                                      13,
                                      16,
                                      17,
                                      19
                                    ]
                                  }
                                ]";

            List<People> listMembers = JsonConvert.DeserializeObject<List<People>>(json);
            dgvLista.DataSource = listMembers;

        }
    }
}
