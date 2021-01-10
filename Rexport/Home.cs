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
            if(s.Length <= 0)
            {
                return "There İs No String <<<<<<<<<!!";
            }

            int startIndex = s.IndexOf(start) + start.Length;
            int endIndex = s.IndexOf(end, startIndex);
            return s.Substring(startIndex, endIndex - startIndex);
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
            String htmlCode = client.DownloadString("https://se.ieu.edu.tr/en/syllabus/type/read/id/CE+221");

           


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
            
            
            String courseName = ExtractString(lines[90], ">", "<").Trim();

            String courseCode = ExtractString(lines[108], ">", "<").Trim();
            String courseSemester = ExtractString(lines[110], ">", "<").Trim();
            String courseWeeklyHours = ExtractString(lines[112], ">", "<").Trim();
            String courseAppHours = ExtractString(lines[114], ">", "<").Trim();
            String courseLocalCredits = ExtractString(lines[116], ">", "<").Trim();
            String courseECTS = ExtractString(lines[118], ">", "<").Trim();

        
            String coursePrerequisites = ExtractString(GetLine(lines[122],4), ">", "<").Trim();
            String courseLanguage = ExtractString(lines[125], ">", "<").Trim();
            String courseType = ExtractString(lines[127], ">", "<").Trim();
            String courseLevel = ExtractString(lines[129], ">", "<").Trim();
            String courseCoordinator = ExtractString(GetLine(lines[130], 9), "\">", "</a></li></ul>").Trim();
            String courseLecturerGetter = ExtractString(GetLine(lines[130], 16), "\">", "</a></li></ul>").Trim();
            String courseLecturer = replaceBetweenWithoutRegex(courseLecturerGetter, "</a>", "\">", true, true, "\n");
            String courseAssistantGetter = ExtractString(GetLine(lines[130], 22), "\">", "</a></li></ul>").Trim();
            String courseAssistants = replaceBetweenWithoutRegex(courseAssistantGetter,"</a>","\">", true, true, "\n");

            String courseObjectives = ExtractString(GetLine(lines[132], 6), "<td>", "</td>").Trim();
            String courseLearningOutcomes1 = ExtractString(GetLine(lines[132], 13), "<span>", "</span>").Trim();
            String courseLearningOutcomes2 = fixingGaps(StripHTML(GetLine(lines[132], 14)));
            String courseDescription = ExtractString(GetLine(lines[132], 20), "<td>", "</td>").Trim();

            //Course category is gonna come here....

            //Week Subjects Related Preparation part
            String courseSubjectW1 = ExtractString(GetLine(lines[150], 9), "<td>", "</td>").Trim();
            String courseRelatedpreparationW1 = ExtractString(GetLine(lines[150], 10), "<td>", "</td>").Trim();

            String courseSubjectW2 = ExtractString(GetLine(lines[150], 14), "<td>", "</td>").Trim();
            String courseRelatedpreparationW2 = ExtractString(GetLine(lines[150], 15), "<td>", "</td>").Trim();

            String courseSubjectW3 = ExtractString(GetLine(lines[150], 19), "<td>", "</td>").Trim();
            String courseRelatedpreparationW3 = ExtractString(GetLine(lines[150], 20), "<td>", "</td>").Trim();

            String courseSubjectW4 = ExtractString(GetLine(lines[150], 24), "<td>", "</td>").Trim();
            String courseRelatedpreparationW4 = ExtractString(GetLine(lines[150], 25), "<td>", "</td>").Trim();

            String courseSubjectW5 = ExtractString(GetLine(lines[150], 29), "<td>", "</td>").Trim();
            String courseRelatedpreparationW5 = ExtractString(GetLine(lines[150], 30), "<td>", "</td>").Trim();

            String courseSubjectW6 = ExtractString(GetLine(lines[150], 34), "<td>", "</td>").Trim();
            String courseRelatedpreparationW6 = ExtractString(GetLine(lines[150], 35), "<td>", "</td>").Trim();

            String courseSubjectW7 = ExtractString(GetLine(lines[150], 39), "<td>", "</td>").Trim();
            String courseRelatedpreparationW7 = ExtractString(GetLine(lines[150], 40), "<td>", "</td>").Trim();

            String courseSubjectW8 = ExtractString(GetLine(lines[150], 44), "<td>", "</td>").Trim();
            String courseRelatedpreparationW8 = ExtractString(GetLine(lines[150], 45), "<td>", "</td>").Trim();

            String courseSubjectW9 = ExtractString(GetLine(lines[150], 49), "<td>", "</td>").Trim();
            String courseRelatedpreparationW9 = ExtractString(GetLine(lines[150], 50), "<td>", "</td>").Trim();

            String courseSubjectW10 = ExtractString(GetLine(lines[150], 54), "<td>", "</td>").Trim();
            String courseRelatedpreparationW10 = ExtractString(GetLine(lines[150], 55), "<td>", "</td>").Trim();

            String courseSubjectW11 = ExtractString(GetLine(lines[150], 59), "<td>", "</td>").Trim();
            String courseRelatedpreparationW11 = ExtractString(GetLine(lines[150], 60), "<td>", "</td>").Trim();

            String courseSubjectW12 = ExtractString(GetLine(lines[150], 64), "<td>", "</td>").Trim();
            String courseRelatedpreparationW12 = ExtractString(GetLine(lines[150], 65), "<td>", "</td>").Trim();

            String courseSubjectW13 = ExtractString(GetLine(lines[150], 69), "<td>", "</td>").Trim();
            String courseRelatedpreparationW13 = ExtractString(GetLine(lines[150], 70), "<td>", "</td>").Trim();

            String courseSubjectW14 = ExtractString(GetLine(lines[150], 74), "<td>", "</td>").Trim();
            String courseRelatedpreparationW14 = ExtractString(GetLine(lines[150], 75), "<td>", "</td>").Trim();

            String courseSubjectW15 = ExtractString(GetLine(lines[150], 79), "<td>", "</td>").Trim();
            String courseRelatedpreparationW15 = ExtractString(GetLine(lines[150], 80), "<td>", "</td>").Trim();

            String courseSubjectW16 = ExtractString(GetLine(lines[150], 84), "<td>", "</td>").Trim();
            String courseRelatedpreparationW16 = ExtractString(GetLine(lines[150], 85), "<td>", "</td>").Trim();


            //Course NoteBooks
            String courseNotesTextbooks = ExtractString(GetLine(lines[152], 6), "<p>", "</p>").Trim();
            String courseSuggestedReadingsMaterials = ExtractString(GetLine(lines[152], 13), "<td>", "</td>").Trim();

            ArrayList weights = new ArrayList();
            ArrayList nos = new ArrayList();
            //Evaluation System
            String courseParticipationNo = ExtractString(lines[157], ">", "<").Trim();
            String courseParticipationWeight = ExtractString(lines[159], ">", "<").Trim();
            weights.Add(courseParticipationWeight);
            nos.Add(courseParticipationWeight);

            String courseLabNo = ExtractString(lines[161], ">", "<").Trim();
            String courseLabWeight = ExtractString(lines[163], ">", "<").Trim();
            weights.Add(courseLabWeight);
            nos.Add(courseLabNo);

            String courseFieldWorkNo = ExtractString(lines[165], ">", "<").Trim();
            String courseFieldWorkWeight = ExtractString(lines[167], ">", "<").Trim();
            weights.Add(courseFieldWorkWeight);
            nos.Add(courseFieldWorkNo);

            String courseQuizNo = ExtractString(lines[169], ">", "<").Trim();
            String courseQuizWeight = ExtractString(lines[171], ">", "<").Trim();
            weights.Add(courseQuizWeight);
            nos.Add(courseQuizNo);

            String courseHomeworkNo = ExtractString(lines[173], ">", "<").Trim();
            String courseHomeworkWeight = ExtractString(lines[175], ">", "<").Trim();
            weights.Add(courseHomeworkWeight);
            nos.Add(courseHomeworkNo);

            String coursePresentationNo = ExtractString(lines[177], ">", "<").Trim();
            String coursePresentationWeight = ExtractString(lines[179], ">", "<").Trim();
            weights.Add(coursePresentationWeight);
            nos.Add(coursePresentationNo);

            String courseProjectNo = ExtractString(lines[181], ">", "<").Trim();
            String courseProjectWeight = ExtractString(lines[183], ">", "<").Trim();
            weights.Add(courseProjectWeight);
            nos.Add(courseProjectNo);

            String courseSeminarNo = ExtractString(lines[185], ">", "<").Trim();
            String courseSeminarWeight = ExtractString(lines[187], ">", "<").Trim();
            weights.Add(courseSeminarWeight);
            nos.Add(courseSeminarNo);

            String courseOralNo = ExtractString(lines[189], ">", "<").Trim();
            String courseOralWeight = ExtractString(lines[191], ">", "<").Trim();
            weights.Add(courseOralWeight);
            nos.Add(courseOralNo);

            String courseMidtermNo = ExtractString(lines[193], ">", "<").Trim();
            String courseMidtermWeight = ExtractString(lines[195], ">", "<").Trim();
            weights.Add(courseMidtermWeight);
            nos.Add(courseMidtermNo);

            String courseFinalNo = ExtractString(lines[197], ">", "<").Trim();
            String courseFinalWeight = ExtractString(lines[199], ">", "<").Trim();
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

            String courseTheoretical2No = ExtractString(lines[219], ">", "<").Trim();
            String courseTheoretical2Duration = ExtractString(lines[221], ">", "<").Trim();
            String courseTheoretical2Workload = ExtractString(lines[223], ">", "<").Trim();
            workLoads.Add(courseTheoretical2Workload);

            String courseLaboratory2No = ExtractString(lines[225], ">", "<").Trim();
            String courseLaboratory2Duration = ExtractString(lines[227], ">", "<").Trim();
            String courseLaboratory2Workload = ExtractString(lines[229], ">", "<").Trim();
            workLoads.Add(courseLaboratory2Workload);

            String courseStudy2No = ExtractString(lines[231], ">", "<").Trim();
            String courseStudy2Duration = ExtractString(lines[233], ">", "<").Trim();
            String courseStudy2Workload = ExtractString(lines[235], ">", "<").Trim();
            workLoads.Add(courseStudy2Workload);


            String courseFieldWork2No = ExtractString(lines[237], ">", "<").Trim();
            String courseFieldWork2Duration = ExtractString(lines[239], ">", "<").Trim();
            String courseFieldWork2Workload = ExtractString(lines[241], ">", "<").Trim();
            workLoads.Add(courseFieldWork2Workload);

            String courseQuiz2No = ExtractString(lines[243], ">", "<").Trim();
            String courseQuiz2Duration = ExtractString(lines[245], ">", "<").Trim();
            String courseQuiz2Workload = ExtractString(lines[247], ">", "<").Trim();
            workLoads.Add(courseQuiz2Workload);

            String courseHomework2No = ExtractString(lines[249], ">", "<").Trim();
            String courseHomework2Duration = ExtractString(lines[251], ">", "<").Trim();
            String courseHomework2Workload = ExtractString(lines[253], ">", "<").Trim();
            workLoads.Add(courseHomework2Workload);

            String coursePresentation2No = ExtractString(lines[255], ">", "<").Trim();
            String coursePresentation2Duration = ExtractString(lines[257], ">", "<").Trim();
            String coursePresentation2Workload = ExtractString(lines[259], ">", "<").Trim();
            workLoads.Add(coursePresentation2Workload);

            String courseProject2No = ExtractString(lines[261], ">", "<").Trim();
            String courseProject2Duration = ExtractString(lines[263], ">", "<").Trim();
            String courseProject2Workload = ExtractString(lines[265], ">", "<").Trim();
            workLoads.Add(courseProject2Workload);

            String courseSeminar2No = ExtractString(lines[267], ">", "<").Trim();
            String courseSeminar2Duration = ExtractString(lines[269], ">", "<").Trim();
            String courseSeminar2Workload = ExtractString(lines[271], ">", "<").Trim();
            workLoads.Add(courseSeminar2Workload);

            String courseOral2No = ExtractString(lines[273], ">", "<").Trim();
            String courseOral2Duration = ExtractString(lines[275], ">", "<").Trim();
            String courseOral2Workload = ExtractString(lines[277], ">", "<").Trim();
            workLoads.Add(courseOral2Workload);

            String courseMidterm2No = ExtractString(lines[279], ">", "<").Trim();
            String courseMidterm2Duration = ExtractString(lines[281], ">", "<").Trim();
            String courseMidterm2Workload = ExtractString(lines[283], ">", "<").Trim();
            workLoads.Add(courseMidterm2Workload);

            String courseFinal2No = ExtractString(lines[285], ">", "<").Trim();
            String courseFinal2Duration = ExtractString(lines[287], ">", "<").Trim();
            String courseFinal2Workload = ExtractString(lines[289], ">", "<").Trim();
            workLoads.Add(courseFinal2Workload);

            int courseTotalWorkload = 0;
            foreach (var workload in workLoads)
            {
                if (workload != "")
                {
                    courseTotalWorkload += Convert.ToInt32(workload);
                }
            }



            /* EXAMPLES EDING DATA INTO EDIT PANEL*/

            textBox304.Text = courseName;
            textBox306.Text = courseCode;

            if (courseSemester == "Fall"|| courseSemester == "Güz")
            {
                checkBox20.Checked = true;
            }
            else
            {
                checkBox19.Checked = true;
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
