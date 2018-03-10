using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legendary_v1._0
{
    public partial class Form1 : Form
    {
        //Declare Global Variables
        List<PlayableCard> HeroDeck = new List<PlayableCard>();
        List<PlayableCard> HQList = new List<PlayableCard>();
        List<DefeatableCard> VillainDeck = new List<DefeatableCard>();
        //List<DefeatableCard> CityList = new List<DefeatableCard>();
        List<DefeatableCard> EscapedVillainsList = new List<DefeatableCard>();
        List<PlayableCard> PlayerDeck = new List<PlayableCard>();

        DefeatableCard[] CityArray = new DefeatableCard[5]; 
        

        DefeatableCard mastermind = new DefeatableCard();
        Card scheme = new Card(); 

        public Form1()
        {
            InitializeComponent();

            //Set Up Board
            addHeroDeck("SM", "CA", "WV", "IM", "HK");
            addMastermindandScheme("LK","NZPB");
            addVillainDeck("EOA", "SF", "HN");
            addPlayerDeck();

        }

        private void addHeroDeck(String char1, String char2, String char3, String char4, String char5)
        {
            //Puts the five selected characters in the HeroDeck
            if (char1.Equals("SM") || char2.Equals("SM") || char3.Equals("SM") || char4.Equals("SM") || char5.Equals("SM"))
            {
                PlayableCard SM_AS1 = new PlayableCard(2, 1, 0, "Green", "SM_AS");
                HeroDeck.Add(SM_AS1);
                PlayableCard SM_AS2 = new PlayableCard(2, 1, 0, "Green", "SM_AS");
                HeroDeck.Add(SM_AS2);
                PlayableCard SM_AS3 = new PlayableCard(2, 1, 0, "Green", "SM_AS");
                HeroDeck.Add(SM_AS3);
                PlayableCard SM_AS4 = new PlayableCard(2, 1, 0, "Green", "SM_AS");
                HeroDeck.Add(SM_AS4);
                PlayableCard SM_AS5 = new PlayableCard(2, 1, 0, "Green", "SM_AS");
                HeroDeck.Add(SM_AS5);
                PlayableCard SM_GR1 = new PlayableCard(2, 0, 1, "Yellow", "SM_GR");
                HeroDeck.Add(SM_GR1);
                PlayableCard SM_GR2 = new PlayableCard(2, 0, 1, "Yellow", "SM_GR");
                HeroDeck.Add(SM_GR2);
                PlayableCard SM_GR3 = new PlayableCard(2, 0, 1, "Yellow", "SM_GR");
                HeroDeck.Add(SM_GR3);
                PlayableCard SM_GR4 = new PlayableCard(2, 0, 1, "Yellow", "SM_GR");
                HeroDeck.Add(SM_GR4);
                PlayableCard SM_GR5 = new PlayableCard(2, 0, 1, "Yellow", "SM_GR");
                HeroDeck.Add(SM_GR5);
                PlayableCard SM_TASM1 = new PlayableCard(2, 0, 0, "Red", "SM_TASM");
                HeroDeck.Add(SM_TASM1);
                PlayableCard SM_WS1 = new PlayableCard(2, 0, 0, "Gray", "SM_WS");
                HeroDeck.Add(SM_WS1);
                PlayableCard SM_WS2 = new PlayableCard(2, 0, 0, "Gray", "SM_WS");
                HeroDeck.Add(SM_WS2);
                PlayableCard SM_WS3 = new PlayableCard(2, 0, 0, "Gray", "SM_WS");
                HeroDeck.Add(SM_WS3);
            }
            if (char1.Equals("CA") || char2.Equals("CA") || char3.Equals("CA") || char4.Equals("CA") || char5.Equals("CA"))
            {
                PlayableCard CA_AA1 = new PlayableCard(3, 0, 0, "Yellow", "CA_AA");
                HeroDeck.Add(CA_AA1);
                PlayableCard CA_AA2 = new PlayableCard(3, 0, 0, "Yellow", "CA_AA");
                HeroDeck.Add(CA_AA2);
                PlayableCard CA_AA3 = new PlayableCard(3, 0, 0, "Yellow", "CA_AA");
                HeroDeck.Add(CA_AA3);
                PlayableCard CA_AA4 = new PlayableCard(3, 0, 0, "Yellow", "CA_AA");
                HeroDeck.Add(CA_AA4);
                PlayableCard CA_AA5 = new PlayableCard(3, 0, 0, "Yellow", "CA_AA");
                HeroDeck.Add(CA_AA5);
                PlayableCard CA_ADUAO1 = new PlayableCard(7, 0, 3, "Red", "CA_ADUAO");
                HeroDeck.Add(CA_ADUAO1);
                PlayableCard CA_DB1 = new PlayableCard(6, 0, 4, "Gray", "CA_DB");
                HeroDeck.Add(CA_DB1);
                PlayableCard CA_DB2 = new PlayableCard(6, 0, 4, "Gray", "CA_DB");
                HeroDeck.Add(CA_DB2);
                PlayableCard CA_DB3 = new PlayableCard(6, 0, 4, "Gray", "CA_DB");
                HeroDeck.Add(CA_DB3);
                PlayableCard CA_PT1 = new PlayableCard(4, 0, 0, "Green", "CA_PT");
                HeroDeck.Add(CA_PT1);
                PlayableCard CA_PT2 = new PlayableCard(4, 0, 0, "Green", "CA_PT");
                HeroDeck.Add(CA_PT2);
                PlayableCard CA_PT3 = new PlayableCard(4, 0, 0, "Green", "CA_PT");
                HeroDeck.Add(CA_PT3);
                PlayableCard CA_PT4 = new PlayableCard(4, 0, 0, "Green", "CA_PT");
                HeroDeck.Add(CA_PT4);
                PlayableCard CA_PT5 = new PlayableCard(4, 0, 0, "Green", "CA_PT");
                HeroDeck.Add(CA_PT5);
            }
            if (char1.Equals("WV") || char2.Equals("WV") || char3.Equals("WV") || char4.Equals("WV") || char5.Equals("WV"))
            {
                PlayableCard WV_BR1 = new PlayableCard(8, 0, 0, "Yellow", "WV_BR");
                HeroDeck.Add(WV_BR1);
                PlayableCard WV_FS1 = new PlayableCard(5, 0, 2, "Yellow", "WV_FA");
                HeroDeck.Add(WV_FS1);
                PlayableCard WV_FS2 = new PlayableCard(5, 0, 2, "Yellow", "WV_FA");
                HeroDeck.Add(WV_FS2);
                PlayableCard WV_FS3 = new PlayableCard(5, 0, 2, "Yellow", "WV_FA");
                HeroDeck.Add(WV_FS3);
                PlayableCard WV_HF1 = new PlayableCard(3, 0, 2, "Yellow", "WV_HF");
                HeroDeck.Add(WV_HF1);
                PlayableCard WV_HF2 = new PlayableCard(3, 0, 2, "Yellow", "WV_HF");
                HeroDeck.Add(WV_HF2);
                PlayableCard WV_HF3 = new PlayableCard(3, 0, 2, "Yellow", "WV_HF");
                HeroDeck.Add(WV_HF3);
                PlayableCard WV_HF4 = new PlayableCard(3, 0, 2, "Yellow", "WV_HF");
                HeroDeck.Add(WV_HF4);
                PlayableCard WV_HF5 = new PlayableCard(3, 0, 2, "Yellow", "WV_HF");
                HeroDeck.Add(WV_HF5);
                PlayableCard WV_KS1 = new PlayableCard(2, 0, 1, "Yellow", "WV_KS");
                HeroDeck.Add(WV_KS1);
                PlayableCard WV_KS2 = new PlayableCard(2, 0, 1, "Yellow", "WV_KS");
                HeroDeck.Add(WV_KS2);
                PlayableCard WV_KS3 = new PlayableCard(2, 0, 1, "Yellow", "WV_KS");
                HeroDeck.Add(WV_KS3);
                PlayableCard WV_KS4 = new PlayableCard(2, 0, 1, "Yellow", "WV_KS");
                HeroDeck.Add(WV_KS4);
                PlayableCard WV_KS5 = new PlayableCard(2, 0, 1, "Yellow", "WV_KS");
                HeroDeck.Add(WV_KS5);

            }
            if (char1.Equals("IM") || char2.Equals("IM") || char3.Equals("IM") || char4.Equals("IM") || char5.Equals("IM"))
            {
                PlayableCard IM_AR1 = new PlayableCard(4, 0, 3, "Gray", "IM_AR");
                HeroDeck.Add(IM_AR1);
                PlayableCard IM_AR2 = new PlayableCard(4, 0, 3, "Gray", "IM_AR");
                HeroDeck.Add(IM_AR2);
                PlayableCard IM_AR3 = new PlayableCard(4, 0, 3, "Gray", "IM_AR");
                HeroDeck.Add(IM_AR3);
                PlayableCard IM_EI1 = new PlayableCard(3, 0, 2, "Gray", "IM_EI");
                HeroDeck.Add(IM_EI1);
                PlayableCard IM_EI2 = new PlayableCard(3, 0, 2, "Gray", "IM_EI");
                HeroDeck.Add(IM_EI2);
                PlayableCard IM_EI3 = new PlayableCard(3, 0, 2, "Gray", "IM_EI");
                HeroDeck.Add(IM_EI3);
                PlayableCard IM_EI4 = new PlayableCard(3, 0, 2, "Gray", "IM_EI");
                HeroDeck.Add(IM_EI4);
                PlayableCard IM_EI5 = new PlayableCard(3, 0, 2, "Gray", "IM_EI");
                HeroDeck.Add(IM_EI5);
                PlayableCard IM_QB1 = new PlayableCard(7, 0, 2, "Gray", "IM_QB");
                HeroDeck.Add(IM_QB1);
                PlayableCard IM_RR1 = new PlayableCard(3, 0, 2, "Blue", "IM_RR");
                HeroDeck.Add(IM_RR1);
                PlayableCard IM_RR2 = new PlayableCard(3, 0, 2, "Blue", "IM_RR");
                HeroDeck.Add(IM_RR2);
                PlayableCard IM_RR3 = new PlayableCard(3, 0, 2, "Blue", "IM_RR");
                HeroDeck.Add(IM_RR3);
                PlayableCard IM_RR4 = new PlayableCard(3, 0, 2, "Blue", "IM_RR");
                HeroDeck.Add(IM_RR4);
                PlayableCard IM_RR5 = new PlayableCard(3, 0, 2, "Blue", "IM_RR");
                HeroDeck.Add(IM_RR5);
            }
            if (char1.Equals("HK") || char2.Equals("HK") || char3.Equals("HK") || char4.Equals("HK") || char5.Equals("HK"))
            {
                PlayableCard HK_CR1 = new PlayableCard(5, 0, 4, "Green", "HK_CR");
                HeroDeck.Add(HK_CR1);
                PlayableCard HK_CR2 = new PlayableCard(5, 0, 4, "Green", "HK_CR");
                HeroDeck.Add(HK_CR2);
                PlayableCard HK_CR3 = new PlayableCard(5, 0, 4, "Green", "HK_CR");
                HeroDeck.Add(HK_CR3);
                PlayableCard HK_GA1 = new PlayableCard(3, 0, 2, "Green", "HK_GA");
                HeroDeck.Add(HK_GA1);
                PlayableCard HK_GA2 = new PlayableCard(3, 0, 2, "Green", "HK_GA");
                HeroDeck.Add(HK_GA2);
                PlayableCard HK_GA3 = new PlayableCard(3, 0, 2, "Green", "HK_GA");
                HeroDeck.Add(HK_GA3);
                PlayableCard HK_GA4 = new PlayableCard(3, 0, 2, "Green", "HK_GA");
                HeroDeck.Add(HK_GA4);
                PlayableCard HK_GA5 = new PlayableCard(3, 0, 2, "Green", "HK_GA");
                HeroDeck.Add(HK_GA5);
                PlayableCard HK_HS1 = new PlayableCard(8, 0, 5, "Green", "HK_HS");
                HeroDeck.Add(HK_HS1);
                PlayableCard HK_UH1 = new PlayableCard(4, 0, 2, "Yellow", "HK_UH");
                HeroDeck.Add(HK_UH1);
                PlayableCard HK_UH2 = new PlayableCard(4, 0, 2, "Yellow", "HK_UH");
                HeroDeck.Add(HK_UH2);
                PlayableCard HK_UH3 = new PlayableCard(4, 0, 2, "Yellow", "HK_UH");
                HeroDeck.Add(HK_UH3);
                PlayableCard HK_UH4 = new PlayableCard(4, 0, 2, "Yellow", "HK_UH");
                HeroDeck.Add(HK_UH4);
                PlayableCard HK_UH5 = new PlayableCard(4, 0, 2, "Yellow", "HK_UH");
                HeroDeck.Add(HK_UH5);
            }
            
            
            //Put first 5 cards in HQList and Displays them
            Random rand = new Random();

            int r = rand.Next(0, HeroDeck.Count - 1);
            PlayableCard cardToAdd = HeroDeck.ElementAt(r);
            HeroDeck.RemoveAt(r);
            HQList.Insert(0, cardToAdd);
            DisplayCardImage(pictureBox_HQ1, cardToAdd.getName());
            pictureBox_HQ1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_HQ1.Visible = true;
            r = rand.Next(0, HeroDeck.Count - 1);
            cardToAdd = HeroDeck.ElementAt(r);
            HeroDeck.RemoveAt(r);
            HQList.Insert(1, cardToAdd);
            DisplayCardImage(pictureBox_HQ2, cardToAdd.getName());
            pictureBox_HQ2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_HQ2.Visible = true;
            r = rand.Next(0, HeroDeck.Count - 1);
            cardToAdd = HeroDeck.ElementAt(r);
            HeroDeck.RemoveAt(r);
            HQList.Insert(2, cardToAdd);
            DisplayCardImage(pictureBox_HQ3, cardToAdd.getName());
            pictureBox_HQ3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_HQ3.Visible = true;
            r = rand.Next(0, HeroDeck.Count - 1);
            cardToAdd = HeroDeck.ElementAt(r);
            HeroDeck.RemoveAt(r);
            HQList.Insert(3, cardToAdd);
            DisplayCardImage(pictureBox_HQ4, cardToAdd.getName());
            pictureBox_HQ4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_HQ4.Visible = true;
            r = rand.Next(0, HeroDeck.Count - 1);
            cardToAdd = HeroDeck.ElementAt(r);
            HeroDeck.RemoveAt(r);
            HQList.Insert(4, cardToAdd);
            DisplayCardImage(pictureBox_HQ5, cardToAdd.getName());
            pictureBox_HQ5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_HQ5.Visible = true;

            //Make HeroDeck Visible
            pictureBox_HeroDeck.Visible = true;
        }


        private void addMastermindandScheme(String mm, String sch)
        {
            if (mm.Equals("LK")){
                mastermind.setName("LK_MM");
                mastermind.setDefense(10);
                mastermind.setVictoryPoints(5);
                DisplayCardImage(pictureBox_Mastermind, "LK_MM");
                pictureBox_Mastermind.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_Mastermind.Visible = true;
            }

            if (sch.Equals("NZPB"))
            {
                scheme.setName("NZPB");
                DisplayCardImage(pictureBox_Scheme, "NZPB");
                pictureBox_Scheme.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_Scheme.Visible = true; 

            }            
        }

        private void addVillainDeck(String villainGroup1, String villainGroup2, String hench1)
        {
            //Add the Five Master Strike Cards to the VillainDeck
            DefeatableCard masterStrike1 = new DefeatableCard(0,0,"MasterStrike");
            VillainDeck.Add(masterStrike1);
            DefeatableCard masterStrike2 = new DefeatableCard(0, 0, "MasterStrike");
            VillainDeck.Add(masterStrike2);
            DefeatableCard masterStrike3 = new DefeatableCard(0, 0, "MasterStrike");
            VillainDeck.Add(masterStrike3);
            DefeatableCard masterStrike4 = new DefeatableCard(0, 0, "MasterStrike");
            VillainDeck.Add(masterStrike4);
            DefeatableCard masterStrike5 = new DefeatableCard(0, 0, "MasterStrike");
            VillainDeck.Add(masterStrike5);

            //Add 2 Bystander Cards
            DefeatableCard bystander1 = new DefeatableCard(1, 0, "Bystander");
            VillainDeck.Add(bystander1);
            DefeatableCard bystander2 = new DefeatableCard(1, 0, "Bystander");
            VillainDeck.Add(bystander2);

            //Add the Villain Group to the VillainDeck
            if (villainGroup1.Equals("EOA") || villainGroup2.Equals("EOA"))
            {
                DefeatableCard EOA_D1 = new DefeatableCard(5, 7, "EOA_D");
                VillainDeck.Add(EOA_D1);
                DefeatableCard EOA_D2 = new DefeatableCard(5, 7, "EOA_D");
                VillainDeck.Add(EOA_D2);
                DefeatableCard EOA_E1 = new DefeatableCard(4, 6, "EOA_E");
                VillainDeck.Add(EOA_E1);
                DefeatableCard EOA_E2 = new DefeatableCard(4, 6, "EOA_E");
                VillainDeck.Add(EOA_E2);
                DefeatableCard EOA_FG1 = new DefeatableCard(2, 4, "EOA_FG");
                VillainDeck.Add(EOA_FG1);
                DefeatableCard EOA_FG2 = new DefeatableCard(2, 4, "EOA_FG");
                VillainDeck.Add(EOA_FG2);
                DefeatableCard EOA_YFGK1 = new DefeatableCard(4, 6, "EOA_YFGK");
                VillainDeck.Add(EOA_YFGK1);
                DefeatableCard EOA_YFGK2 = new DefeatableCard(4, 6, "EOA_YFGK");
                VillainDeck.Add(EOA_YFGK2);
            }

            if (villainGroup1.Equals("SF") || villainGroup2.Equals("SF"))
            {
                DefeatableCard SF_DO1 = new DefeatableCard(2, 4, "SF_DO");
                VillainDeck.Add(SF_DO1);
                DefeatableCard SF_DO2 = new DefeatableCard(2, 4, "SF_DO");
                VillainDeck.Add(SF_DO2);
                DefeatableCard SF_GG1 = new DefeatableCard(4, 6, "SF_GG");
                VillainDeck.Add(SF_GG1);
                DefeatableCard SF_GG2 = new DefeatableCard(4, 6, "SF_GG");
                VillainDeck.Add(SF_GG2);
                DefeatableCard SF_TL1 = new DefeatableCard(2, 3, "SF_TL");
                VillainDeck.Add(SF_TL1);
                DefeatableCard SF_TL2 = new DefeatableCard(2, 3, "SF_TL");
                VillainDeck.Add(SF_TL2);
                DefeatableCard SF_V1 = new DefeatableCard(3, 5, "SF_V");
                VillainDeck.Add(SF_V1);
                DefeatableCard SF_V2 = new DefeatableCard(3, 5, "SF_V");
                VillainDeck.Add(SF_V2);
            }


            //add Henchmen Group(s) to the VillainDeck
            if (hench1.Equals("HN"))
            {
                DefeatableCard HN1 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN1);
                DefeatableCard HN2 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN2);
                DefeatableCard HN3 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN3);
                DefeatableCard HN4 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN4);
                DefeatableCard HN5 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN5);
                DefeatableCard HN6 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN6);
                DefeatableCard HN7 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN7);
                DefeatableCard HN8 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN8);
                DefeatableCard HN9 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN9);
                DefeatableCard HN10 = new DefeatableCard(1, 3, "HN");
                VillainDeck.Add(HN10);
            }
            if (hench1.Equals("SLM"))
            {
                DefeatableCard SLM1 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM1);
                DefeatableCard SLM2 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM2);
                DefeatableCard SLM3 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM3);
                DefeatableCard SLM4 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM4);
                DefeatableCard SLM5 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM5);
                DefeatableCard SLM6 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM6);
                DefeatableCard SLM7 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM7);
                DefeatableCard SLM8 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM8);
                DefeatableCard SLM9 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM9);
                DefeatableCard SLM10 = new DefeatableCard(1, 3, "SLM");
                VillainDeck.Add(SLM10);
            }
            if (hench1.Equals("S"))
            {
                DefeatableCard S1 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S1);
                DefeatableCard S2 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S2);
                DefeatableCard S3 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S3);
                DefeatableCard S4 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S4);
                DefeatableCard S5 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S5);
                DefeatableCard S6 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S6);
                DefeatableCard S7 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S7);
                DefeatableCard S8 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S8);
                DefeatableCard S9 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S9);
                DefeatableCard S10 = new DefeatableCard(1, 3, "S");
                VillainDeck.Add(S10);
            }
            if (hench1.Equals("DL"))
            {
                DefeatableCard DL1 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL1);
                DefeatableCard DL2 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL2);
                DefeatableCard DL3 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL3);
                DefeatableCard DL4 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL4);
                DefeatableCard DL5 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL5);
                DefeatableCard DL6 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL6);
                DefeatableCard DL7 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL7);
                DefeatableCard DL8 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL8);
                DefeatableCard DL9 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL9);
                DefeatableCard DL10 = new DefeatableCard(1, 3, "DL");
                VillainDeck.Add(DL10);
            }

            //Scheme NZPB Requires a second Henchmen Group
            if (scheme.getName().Equals("NZPB"))
            {
                Random rand = new Random();
                int r = rand.Next(0, 3);
                while (r < 5)
                {
                    if (r == 0 && !hench1.Equals("HN"))
                    {
                        DefeatableCard HN1 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN1);
                        DefeatableCard HN2 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN2);
                        DefeatableCard HN3 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN3);
                        DefeatableCard HN4 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN4);
                        DefeatableCard HN5 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN5);
                        DefeatableCard HN6 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN6);
                        DefeatableCard HN7 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN7);
                        DefeatableCard HN8 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN8);
                        DefeatableCard HN9 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN9);
                        DefeatableCard HN10 = new DefeatableCard(1, 3, "HN");
                        VillainDeck.Add(HN10);
                        r = 5;
                    }
                    else if (r == 1 && !hench1.Equals("SLM"))
                    {
                        DefeatableCard SLM1 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM1);
                        DefeatableCard SLM2 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM2);
                        DefeatableCard SLM3 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM3);
                        DefeatableCard SLM4 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM4);
                        DefeatableCard SLM5 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM5);
                        DefeatableCard SLM6 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM6);
                        DefeatableCard SLM7 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM7);
                        DefeatableCard SLM8 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM8);
                        DefeatableCard SLM9 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM9);
                        DefeatableCard SLM10 = new DefeatableCard(1, 3, "SLM");
                        VillainDeck.Add(SLM10);
                        r = 5;
                    }
                    else if (r==2 && !hench1.Equals("S"))
                    {
                        DefeatableCard S1 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S1);
                        DefeatableCard S2 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S2);
                        DefeatableCard S3 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S3);
                        DefeatableCard S4 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S4);
                        DefeatableCard S5 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S5);
                        DefeatableCard S6 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S6);
                        DefeatableCard S7 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S7);
                        DefeatableCard S8 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S8);
                        DefeatableCard S9 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S9);
                        DefeatableCard S10 = new DefeatableCard(1, 3, "S");
                        VillainDeck.Add(S10);
                        r = 5;
                    }
                    else if (r==3 && !hench1.Equals("DL"))
                    {
                        DefeatableCard DL1 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL1);
                        DefeatableCard DL2 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL2);
                        DefeatableCard DL3 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL3);
                        DefeatableCard DL4 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL4);
                        DefeatableCard DL5 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL5);
                        DefeatableCard DL6 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL6);
                        DefeatableCard DL7 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL7);
                        DefeatableCard DL8 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL8);
                        DefeatableCard DL9 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL9);
                        DefeatableCard DL10 = new DefeatableCard(1, 3, "DL");
                        VillainDeck.Add(DL10);
                        r = 5;
                    }
                }
            }

            //Make Villain Deck Visible on Board
            pictureBox_VillainDeck.Visible = true;
        }

        private void addPlayerDeck()
        {
            //Add 8 SHIELD Agents and 4 SHIELD Troopers
            PlayableCard SHIELD_A1 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_A");
            PlayerDeck.Add(SHIELD_A1);
            PlayableCard SHIELD_A2= new PlayableCard(0, 1, 0, "Gray", "SHIELD_A");
            PlayerDeck.Add(SHIELD_A2);
            PlayableCard SHIELD_A3= new PlayableCard(0, 1, 0, "Gray", "SHIELD_A");
            PlayerDeck.Add(SHIELD_A3);
            PlayableCard SHIELD_A4 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_A");
            PlayerDeck.Add(SHIELD_A4);
            PlayableCard SHIELD_A5 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_A");
            PlayerDeck.Add(SHIELD_A5);
            PlayableCard SHIELD_A6 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_A");
            PlayerDeck.Add(SHIELD_A6);
            PlayableCard SHIELD_A7 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_A");
            PlayerDeck.Add(SHIELD_A7);
            PlayableCard SHIELD_A8 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_A");
            PlayerDeck.Add(SHIELD_A8);
            PlayableCard SHIELD_T1 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_T");
            PlayerDeck.Add(SHIELD_T1);
            PlayableCard SHIELD_T2 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_T");
            PlayerDeck.Add(SHIELD_T2);
            PlayableCard SHIELD_T3 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_T");
            PlayerDeck.Add(SHIELD_T3);
            PlayableCard SHIELD_T4 = new PlayableCard(0, 1, 0, "Gray", "SHIELD_T");
            PlayerDeck.Add(SHIELD_T4);


            //Make PictureBox Visible
            pictureBox_PlayerDeck.Visible = true;

        }

        



        private void DisplayCardImage(PictureBox targetPictureBox, String name)
        {
            switch (name)
            {
                case "LK_MM": targetPictureBox.Image = Properties.Resources.LK_MM; break;
                case "NZPB": targetPictureBox.Image = Properties.Resources.NZPB; break;
                case "Wound": targetPictureBox.Image = Properties.Resources.Wound; break;
                case "Bystander": targetPictureBox.Image = Properties.Resources.Bystander; break;
                case "Shield_O": targetPictureBox.Image = Properties.Resources.SHIELD_O; break;
                case "SM_AS": targetPictureBox.Image = Properties.Resources.SM_AS; break;
                case "SM_GR": targetPictureBox.Image = Properties.Resources.SM_GR; break;
                case "SM_TASM": targetPictureBox.Image = Properties.Resources.SM_TASM; break;
                case "SM_WS": targetPictureBox.Image = Properties.Resources.SM_WS; break;
                case "CA_AA": targetPictureBox.Image = Properties.Resources.CA_AA; break;
                case "CA_ADUAO": targetPictureBox.Image = Properties.Resources.CA_ADUAO; break;
                case "CA_DB": targetPictureBox.Image = Properties.Resources.CA_DB; break;
                case "CA_PT": targetPictureBox.Image = Properties.Resources.CA_PT; break;
                case "IM_AR": targetPictureBox.Image = Properties.Resources.IM_AR; break;
                case "IM_EI": targetPictureBox.Image = Properties.Resources.IM_EI; break;
                case "IM_QB": targetPictureBox.Image = Properties.Resources.IM_QB; break;
                case "IM_RR": targetPictureBox.Image = Properties.Resources.IM_RR; break;
                case "HK_CR": targetPictureBox.Image = Properties.Resources.HK_CR; break;
                case "HK_GA": targetPictureBox.Image = Properties.Resources.HK_GA; break;
                case "HK_HS": targetPictureBox.Image = Properties.Resources.HK_HS; break;
                case "HK_UH": targetPictureBox.Image = Properties.Resources.HK_UH; break;
                case "WV_BR": targetPictureBox.Image = Properties.Resources.WV_BR; break;
                case "WV_FS": targetPictureBox.Image = Properties.Resources.WV_FS; break;
                case "WV_HF": targetPictureBox.Image = Properties.Resources.WV_HF; break;
                case "WV_KS": targetPictureBox.Image = Properties.Resources.WV_KS; break;
                case "MasterStrike": targetPictureBox.Image = Properties.Resources.MasterStrike; break;
                case "EOA_D": targetPictureBox.Image = Properties.Resources.EOA_D; break;
                case "EOA_E": targetPictureBox.Image = Properties.Resources.EOA_E; break;
                case "EOA_FG": targetPictureBox.Image = Properties.Resources.EOA_FG; break;
                case "EOA_YFGK": targetPictureBox.Image = Properties.Resources.EOA_YFGK; break;
                case "SF_DO": targetPictureBox.Image = Properties.Resources.SF_DO; break;
                case "SF_GG": targetPictureBox.Image = Properties.Resources.SF_GG; break;
                case "SF_TL": targetPictureBox.Image = Properties.Resources.SF_TL; break;
                case "SF_V": targetPictureBox.Image = Properties.Resources.SF_V; break;
                case "HN": targetPictureBox.Image = Properties.Resources.HN; break;
                case "SLM": targetPictureBox.Image = Properties.Resources.SLM; break;
                case "S": targetPictureBox.Image = Properties.Resources.S; break;
                case "DL": targetPictureBox.Image = Properties.Resources.DL; break;

            }

        }


        //Event Handlers
        private void pictureBox_VillainDeck_Click(object sender, EventArgs e)
        {
            //Get new Villain Card
            Random rand = new Random();
            int r = rand.Next(0, VillainDeck.Count);

            DefeatableCard newVillainCard = VillainDeck.ElementAt(r);
            VillainDeck.RemoveAt(r);

            //Move all cards forward and add new Card in first spot
            int firstNull = -1;

            for (int n = 0; n < 5; n++)
            {
                if (CityArray[n] == null)
                {
                    firstNull = n;
                }
            }


            //If City is not full
            if (firstNull != -1)
            {
                if (firstNull < 4)
                {
                    for (int i = firstNull; i >= 0; i--)
                    {
                        if (CityArray[i] != null)
                        {
                            CityArray[i + 1] = CityArray[i];
                        }
                    }
                    CityArray[0] = newVillainCard;
                }
                //First null is in the last spot
                else
                {
                    for (int i = 3; i >= 0; i--)
                    {
                        if (CityArray[i] != null)
                        {
                            CityArray[i + 1] = CityArray[i];
                        }
                    }
                    CityArray[0] = newVillainCard;
                }
            }
            //If City is full, then a Villain Escapes
            else
            {
                EscapedVillainsList.Add(CityArray[4]);

                for (int i = 3; i >= 0; i--)
                {
                    if (CityArray[i] != null)
                    {
                        CityArray[i + 1] = CityArray[i];
                    }
                }
                CityArray[0] = newVillainCard;

                //Display CardBack for pictureBox_EscapedVillains
                Image flipImage = Properties.Resources.CardBack;
                flipImage.RotateFlip(RotateFlipType.Rotate270FlipXY);
                pictureBox_EscapedVillains.Image = flipImage;
                pictureBox_EscapedVillains.Visible = true;
                pictureBox_EscapedVillains.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            //Update City Space Images
            if (CityArray[0] != null)
            {
                DisplayCardImage(pictureBox_Sewers, CityArray[0].getName());
                pictureBox_Sewers.Visible = true;
                pictureBox_Sewers.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox_Sewers.Visible = false;
            }

            if (CityArray[1] != null)
            {
                DisplayCardImage(pictureBox_Bank, CityArray[1].getName());
                pictureBox_Bank.Visible = true;
                pictureBox_Bank.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox_Bank.Visible = false;
            }

            if (CityArray[2] != null)
            {
                DisplayCardImage(pictureBox_Rooftops, CityArray[2].getName());
                pictureBox_Rooftops.Visible = true;
                pictureBox_Rooftops.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox_Rooftops.Visible = false;
            }

            if (CityArray[3] != null)
            {
                DisplayCardImage(pictureBox_Streets, CityArray[3].getName());
                pictureBox_Streets.Visible = true;
                pictureBox_Streets.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox_Streets.Visible = false;
            }

            if (CityArray[4] != null)
            {
                DisplayCardImage(pictureBox_Bridge, CityArray[4].getName());
                pictureBox_Bridge.Visible = true;
                pictureBox_Bridge.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox_Bridge.Visible = false;
            }
        }

        private void pictureBox_Mastermind_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, mastermind.getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_Scheme_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, scheme.getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_Wound_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, "Wound");
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_Bystander_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, "Bystander");
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_ShieldOfficer_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, "Shield_O");
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_HQ1_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, HQList.ElementAt(0).getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_HQ2_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, HQList.ElementAt(1).getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_HQ3_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, HQList.ElementAt(2).getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_HQ4_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, HQList.ElementAt(3).getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_HQ5_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, HQList.ElementAt(4).getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }



        private void pictureBox_Sewers_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, CityArray[0].getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_Bank_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, CityArray[1].getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_Rooftops_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, CityArray[2].getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_Streets_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, CityArray[3].getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }

        private void pictureBox_Bridge_Click(object sender, EventArgs e)
        {
            DisplayCardImage(pictureBox_Preview, CityArray[4].getName());
            pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Preview.Visible = true;
        }
    }
}
