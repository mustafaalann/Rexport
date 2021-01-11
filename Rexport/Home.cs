﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections;

namespace Rexport
{
    public partial class Home : Form
    {
        public Home(bool isOn)
        {
            InitializeComponent();
            homePanel.Hide();
            editPanel2.Hide();
            editLinkPanel.Show();
            createPanel.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //Hiding the other panels and showing the panel that clicked
            editPanel2.Hide();
            editLinkPanel.Hide();
            createPanel.Hide();
            homePanel.Show();
            homePanel.BringToFront();

            //When the button is clicked the colors of the buttons change
            homeButton.BackColor = Color.FromArgb(255, 213, 101);
            editButton.BackColor = Color.FromArgb(224, 224, 224);
            createButton.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
            //Hiding the other panels and showing the panel that clicked
            homePanel.Hide();
            createPanel.Hide();
            editPanel2.Hide();
            editLinkPanel.Show();
            editLinkPanel.BringToFront();

            //When the button is clicked the colors of the buttons change
            homeButton.BackColor = Color.FromArgb(224, 224, 224);
            editButton.BackColor = Color.FromArgb(255, 213, 101);
            createButton.BackColor = Color.FromArgb(224, 224, 224);

        }
        private void createButton_Click(object sender, EventArgs e)
        {
            //Hiding the other panels and showing the panel that clicked
            homePanel.Hide();
            editPanel2.Hide();
            editLinkPanel.Hide();
            createPanel.Show();
            createPanel.BringToFront();

            //When the button is clicked the colors of the buttons change
            homeButton.BackColor = Color.FromArgb(224, 224, 224);
            editButton.BackColor = Color.FromArgb(224, 224, 224);
            createButton.BackColor = Color.FromArgb(255, 213, 101);
        }

        

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            
        

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void createPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        public static String fixingGaps(string input)
        {
            return System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ");

        }


        public static string StripHTML(string input)
        {
            if(input == null)
            {
                return "";
            }
            return Regex.Replace(input, "<.*?>", String.Empty);
        }



        public static String replaceBetweenWithoutRegex(String str,
                                                 String start, String end,
                                                 bool startInclusive,
                                                 bool endInclusive,
                                                 String replaceWith)
        {
            int i = str.IndexOf(start);
            while (i != -1)
            {
                int j = str.IndexOf(end, i + 1);
                if (j != -1)
                {
                    String data = (startInclusive ? str.Substring(0, i) : str.Substring(0, i + start.Length)) +
                            replaceWith;
                    String temp = (endInclusive ? str.Substring(j + end.Length) : str.Substring(j));
                    data += temp;
                    str = data;
                    i = str.IndexOf(start, i + replaceWith.Length + end.Length + 1);
                }
                else
                {
                    break;
                }
            }
            return str;
        }



        string GetLine(string text, int lineNo)
        {
            string[] lines = text.Replace("\r", "").Split('\n');
            return lines.Length >= lineNo ? lines[lineNo - 1] : null;
        }


        public string ExtractString(string s, string start, string end)
        {
            // You should check for errors in real-world code, omitted for brevity
            if (s == null)
            {
                return "None";
            }

            int startIndex = s.IndexOf(start) + start.Length;
            int endIndex = s.IndexOf(end, startIndex);
            try
            {
                return s.Substring(startIndex, endIndex - startIndex);
            }
            catch(System.ArgumentOutOfRangeException ex)
            {
                return "";
            }
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            homePanel.Hide();
            editPanel2.Show();
            editLinkPanel.Hide();
            createPanel.Hide();
            editPanel2.BringToFront();



            int cnt = 0;
            WebClient client = new WebClient();
            String htmlCode = client.DownloadString("https://se.ieu.edu.tr/en/syllabus/type/read/id/SE+302");

           


            byte[] bytes = Encoding.Default.GetBytes(htmlCode);
            htmlCode = Encoding.UTF8.GetString(bytes);




            string[] separatingStrings = {"div"};

            string text = htmlCode;

            string[] lines = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            
            

            foreach (var line in lines)
            {
                System.Console.WriteLine(cnt);
                System.Console.WriteLine(line);
                 cnt += 1;
            }

            int a = 0; //controlling if there is None prerequisites
            
            String courseName = ExtractString(lines[90], ">", "<").Trim();

            String courseCode = ExtractString(lines[108], ">", "<").Trim();
            String courseSemester = ExtractString(lines[110], ">", "<").Trim();
            String courseWeeklyHours = ExtractString(lines[112], ">", "<").Trim();
            String courseAppHours = ExtractString(lines[114], ">", "<").Trim();
            String courseLocalCredits = ExtractString(lines[116], ">", "<").Trim();
            String courseECTS = ExtractString(lines[118], ">", "<").Trim();

            if(ExtractString(GetLine(lines[122], 4), ">", "<").Trim() == "None")
            {
                a -= 1;
            }
        
            String coursePrerequisites = ExtractString(GetLine(lines[122],4), ">", "<").Trim();
            String courseLanguage = ExtractString(lines[125 + a], ">", "<").Trim();
            String courseType = ExtractString(lines[127 + a], ">", "<").Trim();
            String courseLevel = ExtractString(lines[129 + a], ">", "<").Trim();
            String courseCoordinator = ExtractString(GetLine(lines[130 + a], 9), "\">", "</a></li></ul>").Trim();
            String courseLecturerGetter = ExtractString(GetLine(lines[130 + a], 16), "\">", "</a></li></ul>").Trim();
            String courseLecturer = replaceBetweenWithoutRegex(courseLecturerGetter, "</a>", "\">", true, true, "\n");
            String courseAssistantGetter = ExtractString(GetLine(lines[130 + a], 22), "\">", "</a></li></ul>").Trim();
            String courseAssistants = replaceBetweenWithoutRegex(courseAssistantGetter,"</a>","\">", true, true, "\n");

            String courseObjectives = ExtractString(GetLine(lines[132 + a], 6), "<td>", "</td>").Trim();
            String courseLearningOutcomes1 = ExtractString(GetLine(lines[132 + a], 13), "<span>", "</span>").Trim();
            String courseLearningOutcomes2 = fixingGaps(StripHTML(GetLine(lines[132 + a], 14)));
            String courseDescription = ExtractString(GetLine(lines[132 + a], 20), "<td>", "</td>").Trim();

            //Course category is gonna come here....

            //Week Subjects Related Preparation part
            String courseSubjectW1 = ExtractString(GetLine(lines[150 + a], 9), "<td>", "</td>").Trim();
            String courseRelatedpreparationW1 = ExtractString(GetLine(lines[150 + a], 10), "<td>", "</td>").Trim();

            String courseSubjectW2 = ExtractString(GetLine(lines[150 + a], 14), "<td>", "</td>").Trim();
            String courseRelatedpreparationW2 = ExtractString(GetLine(lines[150 + a], 15), "<td>", "</td>").Trim();

            String courseSubjectW3 = ExtractString(GetLine(lines[150 + a], 19), "<td>", "</td>").Trim();
            String courseRelatedpreparationW3 = ExtractString(GetLine(lines[150 + a], 20), "<td>", "</td>").Trim();

            String courseSubjectW4 = ExtractString(GetLine(lines[150 + a], 24), "<td>", "</td>").Trim();
            String courseRelatedpreparationW4 = ExtractString(GetLine(lines[150 + a], 25), "<td>", "</td>").Trim();

            String courseSubjectW5 = ExtractString(GetLine(lines[150 + a], 29), "<td>", "</td>").Trim();
            String courseRelatedpreparationW5 = ExtractString(GetLine(lines[150 + a], 30), "<td>", "</td>").Trim();

            String courseSubjectW6 = ExtractString(GetLine(lines[150 + a], 34), "<td>", "</td>").Trim();
            String courseRelatedpreparationW6 = ExtractString(GetLine(lines[150 + a], 35), "<td>", "</td>").Trim();

            String courseSubjectW7 = ExtractString(GetLine(lines[150 + a], 39), "<td>", "</td>").Trim();
            String courseRelatedpreparationW7 = ExtractString(GetLine(lines[150 + a], 40), "<td>", "</td>").Trim();

            String courseSubjectW8 = ExtractString(GetLine(lines[150 + a], 44), "<td>", "</td>").Trim();
            String courseRelatedpreparationW8 = ExtractString(GetLine(lines[150 + a], 45), "<td>", "</td>").Trim();

            String courseSubjectW9 = ExtractString(GetLine(lines[150 + a], 49), "<td>", "</td>").Trim();
            String courseRelatedpreparationW9 = ExtractString(GetLine(lines[150 + a], 50), "<td>", "</td>").Trim();

            String courseSubjectW10 = ExtractString(GetLine(lines[150 + a], 54), "<td>", "</td>").Trim();
            String courseRelatedpreparationW10 = ExtractString(GetLine(lines[150 + a], 55), "<td>", "</td>").Trim();

            String courseSubjectW11 = ExtractString(GetLine(lines[150 + a], 59), "<td>", "</td>").Trim();
            String courseRelatedpreparationW11 = ExtractString(GetLine(lines[150 + a], 60), "<td>", "</td>").Trim();

            String courseSubjectW12 = ExtractString(GetLine(lines[150 + a], 64), "<td>", "</td>").Trim();
            String courseRelatedpreparationW12 = ExtractString(GetLine(lines[150 + a], 65), "<td>", "</td>").Trim();

            String courseSubjectW13 = ExtractString(GetLine(lines[150 + a], 69), "<td>", "</td>").Trim();
            String courseRelatedpreparationW13 = ExtractString(GetLine(lines[150 + a], 70), "<td>", "</td>").Trim();

            String courseSubjectW14 = ExtractString(GetLine(lines[150 + a], 74), "<td>", "</td>").Trim();
            String courseRelatedpreparationW14 = ExtractString(GetLine(lines[150 + a], 75), "<td>", "</td>").Trim();

            String courseSubjectW15 = ExtractString(GetLine(lines[150 + a], 79), "<td>", "</td>").Trim();
            String courseRelatedpreparationW15 = ExtractString(GetLine(lines[150], 80), "<td>", "</td>").Trim();

            String courseSubjectW16 = ExtractString(GetLine(lines[150 + a], 84), "<td>", "</td>").Trim();
            String courseRelatedpreparationW16 = ExtractString(GetLine(lines[150], 85), "<td>", "</td>").Trim();


            //Course NoteBooks
            String courseNotesTextbooks = ExtractString(GetLine(lines[152 + a], 6), "<p>", "</p>").Trim();
            String courseSuggestedReadingsMaterials = ExtractString(GetLine(lines[152 + a], 17), "<p>", "</p>").Trim();

            ArrayList weights = new ArrayList();
            ArrayList nos = new ArrayList();
            //Evaluation System
            String courseParticipationNo = ExtractString(lines[157 + a], ">", "<").Trim();
            String courseParticipationWeight = ExtractString(lines[159 + a], ">", "<").Trim();
            weights.Add(courseParticipationWeight);
            nos.Add(courseParticipationWeight);

            String courseLabNo = ExtractString(lines[161 + a], ">", "<").Trim();
            String courseLabWeight = ExtractString(lines[163 + a], ">", "<").Trim();
            weights.Add(courseLabWeight);
            nos.Add(courseLabNo);

            String courseFieldWorkNo = ExtractString(lines[165 + a], ">", "<").Trim();
            String courseFieldWorkWeight = ExtractString(lines[167 + a], ">", "<").Trim();
            weights.Add(courseFieldWorkWeight);
            nos.Add(courseFieldWorkNo);

            String courseQuizNo = ExtractString(lines[169 + a], ">", "<").Trim();
            String courseQuizWeight = ExtractString(lines[171 + a], ">", "<").Trim();
            weights.Add(courseQuizWeight);
            nos.Add(courseQuizNo);

            String courseHomeworkNo = ExtractString(lines[173 + a], ">", "<").Trim();
            String courseHomeworkWeight = ExtractString(lines[175 + a], ">", "<").Trim();
            weights.Add(courseHomeworkWeight);
            nos.Add(courseHomeworkNo);

            String coursePresentationNo = ExtractString(lines[177 + a], ">", "<").Trim();
            String coursePresentationWeight = ExtractString(lines[179 + a], ">", "<").Trim();
            weights.Add(coursePresentationWeight);
            nos.Add(coursePresentationNo);

            String courseProjectNo = ExtractString(lines[181 + a], ">", "<").Trim();
            String courseProjectWeight = ExtractString(lines[183 + a], ">", "<").Trim();
            weights.Add(courseProjectWeight);
            nos.Add(courseProjectNo);

            String courseSeminarNo = ExtractString(lines[185 + a], ">", "<").Trim();
            String courseSeminarWeight = ExtractString(lines[187 + a], ">", "<").Trim();
            weights.Add(courseSeminarWeight);
            nos.Add(courseSeminarNo);

            String courseOralNo = ExtractString(lines[189 + a], ">", "<").Trim();
            String courseOralWeight = ExtractString(lines[191 + a], ">", "<").Trim();
            weights.Add(courseOralWeight);
            nos.Add(courseOralNo);

            String courseMidtermNo = ExtractString(lines[193 + a], ">", "<").Trim();
            String courseMidtermWeight = ExtractString(lines[195 + a], ">", "<").Trim();
            weights.Add(courseMidtermWeight);
            nos.Add(courseMidtermNo);

            String courseFinalNo = ExtractString(lines[197 + a], ">", "<").Trim();
            String courseFinalWeight = ExtractString(lines[199 + a], ">", "<").Trim();
            weights.Add(courseFinalWeight);
            nos.Add(courseFinalNo);

            int courseTotalNo = 0;

            int courseTotalWeight = 0;


            //where we calculated the numbers on the lines
            foreach (var weight in weights)
            {
                if (weight != "")
                {
                    courseTotalWeight += Convert.ToInt32(weight);
                }
            }
            foreach(var no in nos)
            {
                if (no != "")
                {
                    courseTotalNo += Convert.ToInt32(no);
                }
            }

            //ECTS WORKLOAD TABLE Dont worket the 2s in the variables

            ArrayList workLoads = new ArrayList();

            String courseTheoretical2No = ExtractString(lines[219 + a], ">", "<").Trim();
            String courseTheoretical2Duration = ExtractString(lines[221 + a], ">", "<").Trim();
            String courseTheoretical2Workload = ExtractString(lines[223 + a], ">", "<").Trim();
            workLoads.Add(courseTheoretical2Workload);

            String courseLaboratory2No = ExtractString(lines[225 + a], ">", "<").Trim();
            String courseLaboratory2Duration = ExtractString(lines[227 + a], ">", "<").Trim();
            String courseLaboratory2Workload = ExtractString(lines[229 + a], ">", "<").Trim();
            workLoads.Add(courseLaboratory2Workload);

            String courseStudy2No = ExtractString(lines[231 + a], ">", "<").Trim();
            String courseStudy2Duration = ExtractString(lines[233 + a], ">", "<").Trim();
            String courseStudy2Workload = ExtractString(lines[235 + a], ">", "<").Trim();
            workLoads.Add(courseStudy2Workload);


            String courseFieldWork2No = ExtractString(lines[237 + a], ">", "<").Trim();
            String courseFieldWork2Duration = ExtractString(lines[239 + a], ">", "<").Trim();
            String courseFieldWork2Workload = ExtractString(lines[241 + a], ">", "<").Trim();
            workLoads.Add(courseFieldWork2Workload);

            String courseQuiz2No = ExtractString(lines[243 + a], ">", "<").Trim();
            String courseQuiz2Duration = ExtractString(lines[245 + a], ">", "<").Trim();
            String courseQuiz2Workload = ExtractString(lines[247 + a], ">", "<").Trim();
            workLoads.Add(courseQuiz2Workload);

            String courseHomework2No = ExtractString(lines[249 + a], ">", "<").Trim();
            String courseHomework2Duration = ExtractString(lines[251 + a], ">", "<").Trim();
            String courseHomework2Workload = ExtractString(lines[253 + a], ">", "<").Trim();
            workLoads.Add(courseHomework2Workload);

            String coursePresentation2No = ExtractString(lines[255 + a], ">", "<").Trim();
            String coursePresentation2Duration = ExtractString(lines[257 + a], ">", "<").Trim();
            String coursePresentation2Workload = ExtractString(lines[259 + a], ">", "<").Trim();
            workLoads.Add(coursePresentation2Workload);

            String courseProject2No = ExtractString(lines[261 + a], ">", "<").Trim();
            String courseProject2Duration = ExtractString(lines[263 + a], ">", "<").Trim();
            String courseProject2Workload = ExtractString(lines[265 + a], ">", "<").Trim();
            workLoads.Add(courseProject2Workload);

            String courseSeminar2No = ExtractString(lines[267 + a], ">", "<").Trim();
            String courseSeminar2Duration = ExtractString(lines[269 + a], ">", "<").Trim();
            String courseSeminar2Workload = ExtractString(lines[271 + a], ">", "<").Trim();
            workLoads.Add(courseSeminar2Workload);

            String courseOral2No = ExtractString(lines[273 + a], ">", "<").Trim();
            String courseOral2Duration = ExtractString(lines[275 + a], ">", "<").Trim();
            String courseOral2Workload = ExtractString(lines[277 + a], ">", "<").Trim();
            workLoads.Add(courseOral2Workload);

            String courseMidterm2No = ExtractString(lines[279 + a], ">", "<").Trim();
            String courseMidterm2Duration = ExtractString(lines[281 + a], ">", "<").Trim();
            String courseMidterm2Workload = ExtractString(lines[283 + a], ">", "<").Trim();
            workLoads.Add(courseMidterm2Workload);

            String courseFinal2No = ExtractString(lines[285 + a], ">", "<").Trim();
            String courseFinal2Duration = ExtractString(lines[287 + a], ">", "<").Trim();
            String courseFinal2Workload = ExtractString(lines[289 + a], ">", "<").Trim();
            workLoads.Add(courseFinal2Workload);

            int courseTotalWorkload = 0;
            foreach (var workload in workLoads)
            {
                if (workload != "")
                {
                    courseTotalWorkload += Convert.ToInt32(workload);
                }
            }



            /* EXAMPLES ADDING DATA INTO EDIT PANEL*/

            textBox304.Text = courseName;
            textBox306.Text = courseCode;
            textBox307.Text = courseWeeklyHours; 
            textBox308.Text = courseAppHours;    
            textBox305.Text = courseLocalCredits;
            textBox309.Text = courseECTS;
            textBox303.Text = coursePrerequisites;
            richTextBox34.Text = courseCoordinator;
            richTextBox35.Text = courseLecturer;
            richTextBox36.Text = courseAssistants; 
            richTextBox37.Text = courseObjectives; 
            richTextBox38.Text = courseLearningOutcomes1+courseLearningOutcomes2;
            richTextBox39.Text = courseDescription;

            // CourseCategory !! "X"

            richTextBox2.Text = courseSubjectW1;
            richTextBox3.Text = courseRelatedpreparationW1;
            richTextBox4.Text = courseSubjectW2;
            richTextBox5.Text = courseRelatedpreparationW2;
            richTextBox6.Text = courseSubjectW3;
            richTextBox7.Text = courseRelatedpreparationW3;
            richTextBox8.Text = courseSubjectW4;
            richTextBox9.Text = courseRelatedpreparationW4;
            richTextBox10.Text = courseSubjectW5;
            richTextBox11.Text = courseRelatedpreparationW5;
            richTextBox12.Text = courseSubjectW6;
            richTextBox13.Text = courseRelatedpreparationW6;
            richTextBox14.Text = courseSubjectW7;
            richTextBox15.Text = courseRelatedpreparationW7;
            richTextBox16.Text = courseSubjectW8;
            richTextBox17.Text = courseRelatedpreparationW8;
            richTextBox18.Text = courseSubjectW9;
            richTextBox19.Text = courseRelatedpreparationW9;
            richTextBox20.Text = courseSubjectW10;
            richTextBox21.Text = courseRelatedpreparationW10;
            richTextBox22.Text = courseSubjectW11;
            richTextBox23.Text = courseRelatedpreparationW11;
            richTextBox24.Text = courseSubjectW12;
            richTextBox25.Text = courseRelatedpreparationW12;
            richTextBox26.Text = courseSubjectW13;
            richTextBox27.Text = courseRelatedpreparationW13;
            richTextBox28.Text = courseSubjectW14;
            richTextBox29.Text = courseRelatedpreparationW14;
            richTextBox30.Text = courseSubjectW15;
            richTextBox31.Text = courseRelatedpreparationW15;
            richTextBox32.Text = courseSubjectW16;
            richTextBox33.Text = courseRelatedpreparationW16;

            richTextBox40.Text = courseNotesTextbooks;
            richTextBox41.Text = courseSuggestedReadingsMaterials;

            // !! LO1, LO2, LO3, LO4

            textBox206.Text = courseParticipationNo;
            textBox207.Text = courseParticipationWeight;

            textBox208.Text = courseLabNo;
            textBox209.Text = courseLabWeight;

            textBox211.Text = courseFieldWorkNo;
            textBox212.Text = courseFieldWorkWeight;

            textBox214.Text = courseQuizNo;
            textBox215.Text = courseQuizWeight;

            textBox217.Text = courseHomeworkNo;
            textBox218.Text = courseHomeworkWeight;

            textBox220.Text = coursePresentationNo;
            textBox221.Text = coursePresentationWeight;

            textBox222.Text = courseProjectNo;
            textBox223.Text = courseProjectWeight;

            textBox244.Text = courseSeminarNo;
            textBox245.Text = courseSeminarWeight;

            textBox250.Text = courseOralNo;
            textBox251.Text = courseOralWeight;

            textBox201.Text = courseMidtermNo;
            textBox258.Text = courseMidtermWeight;

            textBox199.Text = courseFinalNo;
            textBox197.Text = courseFinalWeight;

            textBox265.Text = Convert.ToString(courseTotalNo);      
            textBox266.Text = Convert.ToString(courseTotalWeight);

            // SEMESTER TERM FINAL NOTES 
            int finalNoCarry = 0;
            int finalWeightCarry = 0;

            if (courseFinalNo != "")
            {
                finalNoCarry = Convert.ToInt32(courseFinalNo);
            }
            if (courseFinalWeight != "")
            {
                finalWeightCarry = Convert.ToInt32(courseFinalWeight);
            }

            textBox194.Text = Convert.ToString( Convert.ToInt32(courseTotalNo) - finalNoCarry);
            textBox195.Text = Convert.ToString(Convert.ToInt32(courseTotalWeight) - finalWeightCarry);

            textBox196.Text = courseFinalNo;
            textBox193.Text = courseFinalWeight;

            textBox263.Text = Convert.ToString(courseTotalNo);
            textBox264.Text = Convert.ToString(courseTotalWeight);


            // ECTS PART
            textBox152.Text = courseTheoretical2No;
            textBox153.Text = courseTheoretical2Duration;
            textBox151.Text = courseTheoretical2Workload;

            textBox154.Text = courseLaboratory2No;       
            textBox155.Text = courseLaboratory2Duration; 
            textBox156.Text = courseLaboratory2Workload; 

            textBox157.Text = courseStudy2No;
            textBox159.Text = courseStudy2Duration;
            textBox160.Text = courseStudy2Workload;

            textBox161.Text = courseFieldWork2No;
            textBox163.Text = courseFieldWork2Duration;
            textBox164.Text = courseFieldWork2Workload;

            textBox171.Text = courseQuiz2No;
            textBox175.Text = courseQuiz2Duration;
            textBox170.Text = courseQuiz2Workload;

            textBox171.Text = courseHomework2No;
            textBox175.Text = courseHomework2Duration;
            textBox179.Text = courseHomework2Workload;
            

            textBox176.Text = coursePresentation2No;
            textBox177.Text = coursePresentation2Duration;
            textBox181.Text = coursePresentation2Workload;
            

            textBox182.Text = courseProject2No;
            textBox183.Text = courseProject2Duration;
            textBox184.Text = courseProject2Workload;
            

            textBox185.Text = courseSeminar2No;
            textBox186.Text = courseSeminar2Duration;
            textBox187.Text = courseSeminar2Workload;
            

            textBox150.Text = courseOral2No;
            textBox188.Text = courseOral2Duration;
            textBox189.Text = courseOral2Workload;
             

            textBox149.Text = courseMidterm2No;
            textBox148.Text = courseMidterm2Duration;
            textBox190.Text = courseMidterm2Workload;
            

            textBox147.Text = courseFinal2No;
            textBox146.Text = courseFinal2Duration;
            textBox191.Text = courseFinal2Workload;

            textBox192.Text = Convert.ToString(courseTotalWorkload);


            // CourseSemester

            if (courseSemester == "Fall"|| courseSemester == "Güz")
            {
                checkBox20.Checked = true;
            }
            else
            {
                checkBox19.Checked = true;
            }

            // CourseLanguage

            if (courseLanguage == "İngilizce" || courseLanguage == "English")
            {
                checkBox7.Checked = true;
            }
            else
            {
                checkBox8.Checked = true;
            }

            // CourseType

            if (courseType == "Required" || courseLanguage == "Zorunlu")
            {
                checkBox13.Checked = true;
            }
            else
            {
                checkBox14.Checked = true;
            }

            // CourseLevel

            if (courseLevel == "First Cycle" || courseLevel == "Lisans")
            {
                checkBox16.Checked = true;
            }
            else if (courseLevel == "Short Cycle" || courseLevel == "Ön Lisans")
            {
                checkBox15.Checked = true;
            }
            else if (courseLevel == "Second Cycle" || courseLevel == "Yüksek Lisans")
            {
                checkBox17.Checked = true;
            }
            else if (courseLevel == "Third Cycle" || courseLevel == "Doktora")
            {
                checkBox18.Checked = true;
            }

            



            /*     This is a data control String
            richTextBox1.Text = courseName + "\n" + courseCode + "\n" + courseSemester
                + "\n" + courseWeeklyHours + "\n" + courseAppHours + "\n" + courseLocalCredits
                + "\n" + courseECTS + "\n" + coursePrerequisites + "\n" + courseLanguage
                + "\n" + courseType + "\n" + courseLevel + "\n" + courseCoordinator + "\n" + courseLecturer + "\n" + courseAssistants
                + "\n" + "\n" + "\n" + courseObjectives + "\n" + courseLearningOutcomes1 + "\n" + courseLearningOutcomes2 + "\n" + courseDescription
                + "\n" + "\n" + courseSubjectW1 + " ----- " + courseRelatedpreparationW1
                + "\n" + "\n" + courseSubjectW2 + " ----- " + courseRelatedpreparationW2
                + "\n" + "\n" + courseSubjectW3 + " ----- " + courseRelatedpreparationW3
                + "\n" + "\n" + courseSubjectW4 + " ----- " + courseRelatedpreparationW4
                + "\n" + "\n" + courseSubjectW5 + " ----- " + courseRelatedpreparationW5
                + "\n" + "\n" + courseSubjectW6 + " ----- " + courseRelatedpreparationW6
                + "\n" + "\n" + courseSubjectW7 + " ----- " + courseRelatedpreparationW7
                + "\n" + "\n" + courseSubjectW8 + " ----- " + courseRelatedpreparationW8
                + "\n" + "\n" + courseSubjectW9 + " ----- " + courseRelatedpreparationW9
                + "\n" + "\n" + courseSubjectW10 + " ----- " + courseRelatedpreparationW10
                + "\n" + "\n" + courseSubjectW11 + " ----- " + courseRelatedpreparationW11
                + "\n" + "\n" + courseSubjectW12 + " ----- " + courseRelatedpreparationW12
                + "\n" + "\n" + courseSubjectW13 + " ----- " + courseRelatedpreparationW13
                + "\n" + "\n" + courseSubjectW14 + " ----- " + courseRelatedpreparationW14
                + "\n" + "\n" + courseSubjectW15 + " ----- " + courseRelatedpreparationW15
                + "\n" + "\n" + courseSubjectW16 + " ----- " + courseRelatedpreparationW16
                + "\n" + "\n" + "\n" + courseNotesTextbooks + "\n" + courseSuggestedReadingsMaterials
                + "\n" + "\n" + "\n"
                + "\n" + "\n" + courseParticipationNo + " ----- " + courseParticipationWeight
                + "\n" + "\n" + courseLabNo + " ----- " + courseLabWeight
                + "\n" + "\n" + courseFieldWorkNo + " ----- " + courseFieldWorkWeight
                + "\n" + "\n" + courseQuizNo + " ----- " + courseQuizWeight
                + "\n" + "\n" + courseHomeworkNo + " ----- " + courseHomeworkWeight
                + "\n" + "\n" + coursePresentationNo + " ----- " + coursePresentationWeight
                + "\n" + "\n" + courseProjectNo + " ----- " + courseProjectWeight
                + "\n" + "\n" + courseSeminarNo + " ----- " + courseSeminarWeight
                + "\n" + "\n" + courseOralNo + " ----- " + courseOralWeight
                + "\n" + "\n" + courseMidtermNo + " ----- " + courseMidtermWeight
                + "\n" + "\n" + courseFinalNo + " ----- " + courseFinalWeight
                + "\n" + "\n" + courseTotalNo + " ----- " + courseTotalWeight
                + "\n" + "\n" + "\n" + courseTheoretical2No + " ----- " + courseTheoretical2Duration + " ----- " + courseTheoretical2Workload
                + "\n" + "\n" + courseLaboratory2No + " ----- " + courseLaboratory2Duration + " ----- " + courseLaboratory2Workload
                + "\n" + "\n" + courseStudy2No + " ----- " + courseStudy2Duration + " ----- " + courseStudy2Workload
                + "\n" + "\n" + courseFieldWork2No + " ----- " + courseFieldWork2Duration + " ----- " + courseFieldWork2Workload
                + "\n" + "\n" + courseQuiz2No + " ----- " + courseQuiz2Duration + " ----- " + courseQuiz2Workload
                + "\n" + "\n" + courseHomework2No + " ----- " + courseHomework2Duration + " ----- " + courseHomework2Workload
                + "\n" + "\n" + coursePresentation2No + " ----- " + coursePresentation2Duration + " ----- " + coursePresentation2Workload
                + "\n" + "\n" + courseProject2No + " ----- " + courseProject2Duration + " ----- " + courseProject2Workload
                + "\n" + "\n" + courseSeminar2No + " ----- " + courseSeminar2Duration + " ----- " + courseSeminar2Workload
                + "\n" + "\n" + courseOral2No + " ----- " + courseOral2Duration + " ----- " + courseOral2Workload
                + "\n" + "\n" + courseMidterm2No + " ----- " + courseMidterm2Duration + " ----- " + courseMidterm2Workload
                + "\n" + "\n" + courseFinal2No + " ----- " + courseFinal2Duration + " ----- " + courseFinal2Workload
                + "\n" + "\n" + courseTotalWorkload 


                ;
            */






        }
    }
}
