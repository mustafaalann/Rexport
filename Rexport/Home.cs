using System;
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
using System.IO;

namespace Rexport
{
    public partial class Home : Form
    {
        public Home()
        {

            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderName = Path.Combine(projectPath, "Last Syllabus");
            System.IO.Directory.CreateDirectory(folderName);

            InitializeComponent();
            homePanel.Hide();
            editPanel2.Hide();
            editLinkPanel.Hide();
            createPanel.Hide();
            panel1.Show();

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
            if (input == null)
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
            catch (System.ArgumentOutOfRangeException ex)
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


            int a = 0;
            int cnt = 0;
            WebClient client = new WebClient();
            String link = "https://se.ieu.edu.tr/en/syllabus/type/read/id/SE+302";
            String htmlCode = client.DownloadString(link);
            if (ExtractString(link, "https://", ".ieu.edu.tr") == "ce")
            {
                a = a - 6;
            }










            byte[] bytes = Encoding.Default.GetBytes(htmlCode);
            htmlCode = Encoding.UTF8.GetString(bytes);




            string[] separatingStrings = { "div" };

            string text = htmlCode;

            string[] lines = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);



            foreach (var line in lines)
            {
                System.Console.WriteLine(cnt);
                System.Console.WriteLine(line);
                cnt += 1;
            }

            //controlling if there is None prerequisites

            String courseName = ExtractString(lines[90], ">", "<").Trim();

            String courseCode = ExtractString(lines[108], ">", "<").Trim();
            String courseSemester = ExtractString(lines[110], ">", "<").Trim();
            String courseWeeklyHours = ExtractString(lines[112], ">", "<").Trim();
            String courseAppHours = ExtractString(lines[114], ">", "<").Trim();
            String courseLocalCredits = ExtractString(lines[116], ">", "<").Trim();
            String courseECTS = ExtractString(lines[118], ">", "<").Trim();

            if (ExtractString(GetLine(lines[122], 4), ">", "<").Trim() == "None")
            {
                a -= 1;
            }

            String coursePrerequisites = ExtractString(GetLine(lines[122], 4), ">", "<").Trim();
            String courseLanguage = ExtractString(lines[125 + a], ">", "<").Trim();
            String courseType = ExtractString(lines[127 + a], ">", "<").Trim();
            String courseLevel = ExtractString(lines[129 + a], ">", "<").Trim();
            String courseCoordinator = ExtractString(GetLine(lines[130 + a], 9), "\">", "</a></li></ul>").Trim();
            String courseLecturerGetter = ExtractString(GetLine(lines[130 + a], 16), "\">", "</a></li></ul>").Trim();
            String courseLecturer = replaceBetweenWithoutRegex(courseLecturerGetter, "</a>", "\">", true, true, "\n");
            String courseAssistantGetter = ExtractString(GetLine(lines[130 + a], 22), "\">", "</a></li></ul>").Trim();
            String courseAssistants = replaceBetweenWithoutRegex(courseAssistantGetter, "</a>", "\">", true, true, "\n");

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
            foreach (var no in nos)
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

            String W1ProgramCompetencies = ExtractString(GetLine(lines[310 + a], 5), "<p>", "</p>").Trim();
            String W2ProgramCompetencies = ExtractString(GetLine(lines[310 + a], 15), "<p>", "</p>").Trim();
            String W3ProgramCompetencies = ExtractString(GetLine(lines[310 + a], 25), "<p>", "</p>").Trim();
            String W4ProgramCompetencies = ExtractString(GetLine(lines[310 + a], 35), "<p>", "</p>").Trim();
            String W5ProgramCompetencies = ExtractString(GetLine(lines[310 + a], 45), "<p>", "</p>").Trim();
            String W6ProgramCompetencies = ExtractString(GetLine(lines[310 + a], 55), "<p>", "</p>").Trim();
            String W7ProgramCompetencies = ExtractString(GetLine(lines[311 + a], 11), "<p>", "</p>").Trim();
            String W8ProgramCompetencies = ExtractString(GetLine(lines[311 + a], 21), "<p>", "</p>").Trim();
            String W9ProgramCompetencies = ExtractString(GetLine(lines[311 + a], 31), "<p>", "</p>").Trim();
            String W10ProgramCompetencies = ExtractString(GetLine(lines[311 + a], 41), "<p>", "</p>").Trim();
            String W11ProgramCompetencies = ExtractString(GetLine(lines[311 + a], 51), "<p>", "</p>").Trim();
            String W12ProgramCompetencies = ExtractString(GetLine(lines[311 + a], 61), "<p>", "</p>").Trim();
            String W13ProgramCompetencies = ExtractString(GetLine(lines[311 + a], 71), "<p>", "</p>").Trim();



















            /* ADDING DATA INTO EDIT PANEL*/

            textBox304.Text = courseName;
            textBox306.Text = courseCode;
            textBox307.Text = courseWeeklyHours;
            textBox308.Text = courseAppHours;
            textBox305.Text = courseLocalCredits;
            textBox309.Text = courseECTS;
            textBox303.Text = coursePrerequisites;
            textBox97.Text = courseCoordinator;
            textBox98.Text = courseLecturer;
            textBox99.Text = courseAssistants;
            richTextBox37.Text = courseObjectives;
            richTextBox38.Text = courseLearningOutcomes1 + courseLearningOutcomes2;
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

            textBox94.Text = courseParticipationNo;
            textBox93.Text = courseParticipationWeight;

            textBox92.Text = courseLabNo;
            textBox91.Text = courseLabWeight;

            textBox90.Text = courseFieldWorkNo;
            textBox89.Text = courseFieldWorkWeight;

            textBox88.Text = courseQuizNo;
            textBox87.Text = courseQuizWeight;

            textBox86.Text = courseHomeworkNo;
            textBox85.Text = courseHomeworkWeight;

            textBox84.Text = coursePresentationNo;
            textBox83.Text = coursePresentationWeight;

            textBox82.Text = courseProjectNo;
            textBox81.Text = courseProjectWeight;

            textBox80.Text = courseSeminarNo;
            textBox79.Text = courseSeminarWeight;

            textBox78.Text = courseOralNo;
            textBox77.Text = courseOralWeight;

            textBox76.Text = courseMidtermNo;
            textBox75.Text = courseMidtermWeight;

            textBox74.Text = courseFinalNo;
            textBox73.Text = courseFinalWeight;

            textBox95.Text = Convert.ToString(courseTotalNo);
            textBox96.Text = Convert.ToString(courseTotalWeight);

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

            textBox194.Text = Convert.ToString(Convert.ToInt32(courseTotalNo) - finalNoCarry);
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

            if (courseSemester == "Fall" || courseSemester == "Güz")
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

            if (link == "https://se.ieu.edu.tr/en/syllabus/type/read/id/SE+302" || link == "https://ce.ieu.edu.tr/en/syllabus/type/read/id/SE+302")
            {
                W6ProgramCompetencies = "To be able to work effectively in Software Engineering disciplinary and multi-disciplinary teams; to be able to work individually.";
            }




            //LAST PART WRITING ON UI
            richTextBox34.Text = W1ProgramCompetencies;
            richTextBox35.Text = W2ProgramCompetencies;
            richTextBox36.Text = W3ProgramCompetencies;
            richTextBox42.Text = W4ProgramCompetencies;
            richTextBox43.Text = W5ProgramCompetencies;
            richTextBox44.Text = W6ProgramCompetencies;
            richTextBox45.Text = W7ProgramCompetencies;
            richTextBox46.Text = W8ProgramCompetencies;
            richTextBox47.Text = W9ProgramCompetencies;
            richTextBox48.Text = W10ProgramCompetencies;
            richTextBox49.Text = W11ProgramCompetencies;
            richTextBox50.Text = W12ProgramCompetencies;
            richTextBox51.Text = W13ProgramCompetencies;









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

        private void tableLayoutPanel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası|*.html";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.WriteLine(textBox1.Text);
                Kayit.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "template_syllabus.html");

            WebClient client = new WebClient();
            String myHtml = client.DownloadString(path);

            //GENERAL INFORMATION

            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseNameStart", "CourseNameEnd", true, true, textBox304.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "CodeStart", "CodeEnd", true, true, textBox306.Text);

            if (checkBox20.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "FallStart", "FallEnd", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "SpringStart", "SpringEnd", true, true, "");
            }
            else if (checkBox19.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "FallStart", "FallEnd", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "SpringStart", "SpringEnd", true, true, "X");
            }
            myHtml = replaceBetweenWithoutRegex(myHtml, "TheoryStart", "TheoryEnd", true, true, textBox307.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "AppStart", "AppEnd", true, true, textBox308.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "LocalStart", "LocalEnd", true, true, textBox305.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "ECTSStart", "ECTSEnd", true, true, textBox309.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "prerequisitesStart", "prerequisitesEnd", true, true, textBox303.Text);

            if (checkBox7.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "CourseLanguageStart", "CourseLanguageEnd", true, true, "English");
            }
            else if (checkBox8.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "CourseLanguageStart", "CourseLanguageEnd", true, true, "Turkish");
            }

            if (checkBox13.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "CourseTypeStart", "CourseTypeEnd", true, true, "Required");
            }
            else if (checkBox14.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "CourseTypeStart", "CourseTypeEnd", true, true, "Elective");
            }

            if (checkBox15.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "CourseLevelStart", "CourseLevelEnd", true, true, "Short Cycle");
            }
            else if (checkBox16.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "CourseLevelStart", "CourseLevelEnd", true, true, "First Cycle");
            }
            else if (checkBox17.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "CourseLevelStart", "CourseLevelEnd", true, true, "Second Cycle");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "CourseLevelStart", "CourseLevelEnd", true, true, "Third Cycle");
            }

            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseCoordinatorStart", "CourseCoordinatorEnd", true, true, textBox97.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseLecturerStart", "CourseLecturerEnd", true, true, textBox98.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "AssistantStart", "AssistantEnd", true, true, textBox99.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseObjectivesStart", "CourseObjectivesEnd", true, true, richTextBox37.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseLearningStart", "CourseLearningEnd", true, true, richTextBox38.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseDescriptionStart", "CourseDescriptionEnd", true, true, richTextBox39.Text);




            //COURSE CATEGORY
            if (checkBox86.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category1Start", "Category1End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category2Start", "Category2End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category3Start", "Category3End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category4Start", "Category4End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category5Start", "Category5End", true, true, "");
            }
            else if (checkBox87.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category1Start", "Category1End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category2Start", "Category2End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category3Start", "Category3End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category4Start", "Category4End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category5Start", "Category5End", true, true, "");
            }
            else if (checkBox88.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category1Start", "Category1End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category2Start", "Category2End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category3Start", "Category3End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category4Start", "Category4End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category5Start", "Category5End", true, true, "");
            }
            else if (checkBox89.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category1Start", "Category1End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category2Start", "Category2End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category3Start", "Category3End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category4Start", "Category4End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category5Start", "Category5End", true, true, "");
            }

            else if (checkBox90.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category1Start", "Category1End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category2Start", "Category2End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category3Start", "Category3End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category4Start", "Category4End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category5Start", "Category5End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category1Start", "Category1End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category2Start", "Category2End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category3Start", "Category3End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category4Start", "Category4End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "Category5Start", "Category5End", true, true, "");
            }

            //WEEKLY SUBJECTS AND REQUIRED MATERIALS

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week1SubjectStart", "Week1SubjectEnd", true, true, richTextBox2.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week1RequiredStart", "Week1RequiredEnd", true, true, richTextBox3.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week2SubjectStart", "Week2SubjectEnd", true, true, richTextBox4.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week2RequiredStart", "Week2RequiredEnd", true, true, richTextBox5.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week3SubjectStart", "Week3SubjectEnd", true, true, richTextBox6.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week3RequiredStart", "Week3RequiredEnd", true, true, richTextBox7.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week4SubjectStart", "Week4SubjectEnd", true, true, richTextBox8.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week4RequiredStart", "Week4RequiredEnd", true, true, richTextBox9.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week5SubjectStart", "Week5SubjectEnd", true, true, richTextBox10.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week5RequiredStart", "Week5RequiredEnd", true, true, richTextBox11.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week6SubjectStart", "Week6SubjectEnd", true, true, richTextBox12.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week6RequiredStart", "Week6RequiredEnd", true, true, richTextBox13.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week7SubjectStart", "Week7SubjectEnd", true, true, richTextBox14.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week7RequiredStart", "Week7RequiredEnd", true, true, richTextBox15.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week8SubjectStart", "Week8SubjectEnd", true, true, richTextBox16.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week8RequiredStart", "Week8RequiredEnd", true, true, richTextBox17.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week9SubjectStart", "Week9SubjectEnd", true, true, richTextBox18.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week9RequiredStart", "Week9RequiredEnd", true, true, richTextBox19.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week10SubjectStart", "Week10SubjectEnd", true, true, richTextBox20.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week10RequiredStart", "Week10RequiredEnd", true, true, richTextBox21.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week11SubjectStart", "Week11SubjectEnd", true, true, richTextBox22.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week11RequiredStart", "Week11RequiredEnd", true, true, richTextBox23.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week12SubjectStart", "Week12SubjectEnd", true, true, richTextBox24.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week12RequiredStart", "Week12RequiredEnd", true, true, richTextBox25.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week13SubjectStart", "Week13SubjectEnd", true, true, richTextBox26.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week13RequiredStart", "Week13RequiredEnd", true, true, richTextBox27.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week14SubjectStart", "Week14SubjectEnd", true, true, richTextBox28.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week14RequiredStart", "Week14RequiredEnd", true, true, richTextBox29.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week15SubjectStart", "Week15SubjectEnd", true, true, richTextBox30.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week15RequiredStart", "Week15RequiredEnd", true, true, richTextBox31.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Week16SubjectStart", "Week16SubjectEnd", true, true, richTextBox32.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "Week16RequiredStart", "Week16RequiredEnd", true, true, richTextBox33.Text);


            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseNotesStart", "CourseNotesEnd", true, true, richTextBox40.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseSuggestedStart", "CourseSuggestedEnd", true, true, richTextBox41.Text);

            //ASSESMENT


            myHtml = replaceBetweenWithoutRegex(myHtml, "ParticipationNoStart", "ParticipationNoEnd", true, true, textBox94.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "ParticipationWeightStart", "ParticipationWeightEnd", true, true, textBox93.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "LabNoStart", "LabNoEnd", true, true, textBox92.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "LabWeightStart", "LabWeightEnd", true, true, textBox91.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "FieldWorkNoStart", "FieldWorkNoEnd", true, true, textBox90.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "FieldWorkWeightStart", "FieldWorkWeightEnd", true, true, textBox89.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "QuizNoStart", "QuizNoEnd", true, true, textBox88.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "QuizWeightStart", "QuizWeightEnd", true, true, textBox87.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "HomeworkNoStart", "HomeworkNoEnd", true, true, textBox86.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "HomeworkWeightStart", "HomeworkWeightEnd", true, true, textBox85.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "PresentationNoStart", "PresentationNoEnd", true, true, textBox84.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "PresentationWeightStart", "PresentationWeightEnd", true, true, textBox83.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "ProjectNoStart", "ProjectNoEnd", true, true, textBox82.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "ProjectWeightStart", "ProjectWeightEnd", true, true, textBox81.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "SeminarNoStart", "SeminarNoEnd", true, true, textBox80.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "SeminarWeightStart", "SeminarWeightEnd", true, true, textBox79.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "OralNoStart", "OralNoEnd", true, true, textBox78.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "OralWeightStart", "OralWeightEnd", true, true, textBox77.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "MidtermNoStart", "MidtermNoEnd", true, true, textBox76.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "MidtermWeightStart", "MidtermWeightEnd", true, true, textBox75.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "FinalNoStart", "FinalNoEnd", true, true, textBox74.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "FinalWeightStart", "FinalWeightEnd", true, true, textBox73.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "TotalNoStart", "TotalNoEnd", true, true, textBox95.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "TotalWeightStart", "TotalWeightEnd", true, true, textBox96.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "TestingNoStart", "TestingNoEnd", true, true, textBox194.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "TestingWeightStart", "TestingWeightEnd", true, true, textBox195.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Testing2NoStart", "Testing2NoEnd", true, true, textBox196.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "Testing2WeightStart", "Testing2WeightEnd", true, true, textBox193.Text);

            //ECTS

            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseHoursNumberStart", "CourseHoursNumberEnd", true, true, textBox152.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseHoursDurationStart", "CourseHoursDurationEnd", true, true, textBox153.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "CourseHoursWorkloadStart", "CourseHoursWorkloadEnd", true, true, textBox151.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "LabNumberStart", "LabNumberEnd", true, true, textBox154.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "LabDurationStart", "LabDurationEnd", true, true, textBox155.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "LabWorkloadStart", "LabWorkloadEnd", true, true, textBox156.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "StudyNumberStart", "StudyNumberEnd", true, true, textBox157.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "StudyDurationStart", "StudyDurationEnd", true, true, textBox159.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "StudyWorkloadStart", "StudyWorkloadEnd", true, true, textBox160.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "FieldWorkNumberStart", "FieldWorkNumberEnd", true, true, textBox161.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "FieldWorkDurationStart", "FieldWorkDurationEnd", true, true, textBox163.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "FieldWorkWorkloadStart", "FieldWorkWorkloadEnd", true, true, textBox164.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "QuizNumberStart", "QuizNumberEnd", true, true, textBox165.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "QuizDurationStart", "QuizDurationEnd", true, true, textBox169.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "QuizWorkloadStart", "QuizWorkloadEnd", true, true, textBox170.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "HomeworkNumberStart", "HomeworkNumberEnd", true, true, textBox171.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "HomeworkDurationStart", "HomeworkDurationEnd", true, true, textBox175.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "HomeworkWorkloadStart", "HomeworkWorkloadEnd", true, true, textBox179.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "PresentationNumberStart", "PresentationNumberEnd", true, true, textBox176.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "PresentationDurationStart", "PresentationDurationEnd", true, true, textBox177.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "PresentationWorkloadStart", "PresentationWorkloadEnd", true, true, textBox181.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "ProjectNumberStart", "ProjectNumberEnd", true, true, textBox182.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "ProjectDurationStart", "ProjectDurationEnd", true, true, textBox183.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "ProjectWorkloadStart", "ProjectWorkloadEnd", true, true, textBox184.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "SeminarNumberStart", "SeminarNumberEnd", true, true, textBox185.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "SeminarDurationStart", "SeminarDurationEnd", true, true, textBox186.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "SeminarWorkloadStart", "SeminarWorkloadEnd", true, true, textBox187.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "OralExamNumberStart", "OralExamNumberEnd", true, true, textBox150.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "OralExamDurationStart", "OralExamDurationEnd", true, true, textBox188.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "OralExamWorkloadStart", "OralExamWorkloadEnd", true, true, textBox189.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "MidtermNumberStart", "MidtermNumberEnd", true, true, textBox149.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "MidtermDurationStart", "MidtermDurationEnd", true, true, textBox148.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "MidtermWorkloadStart", "MidtermWorkloadEnd", true, true, textBox190.Text);

            myHtml = replaceBetweenWithoutRegex(myHtml, "FinalExamNumberStart", "FinalExamNumberEnd", true, true, textBox147.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "FinalExamDurationStart", "FinalExamDurationEnd", true, true, textBox146.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "FinalExamWorkloadStart", "FinalExamWorkloadEnd", true, true, textBox191.Text);


            myHtml = replaceBetweenWithoutRegex(myHtml, "TotalStart", "TotalEnd", true, true, textBox192.Text);


            //OUTCOME MATRIX

            //OUTCOMES HERE

            myHtml = replaceBetweenWithoutRegex(myHtml, "W1ProgramStart", "W1ProgramEnd", true, true, richTextBox34.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W2ProgramStart", "W2ProgramEnd", true, true, richTextBox35.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W3ProgramStart", "W3ProgramEnd", true, true, richTextBox36.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W4ProgramStart", "W4ProgramEnd", true, true, richTextBox42.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W5ProgramStart", "W5ProgramEnd", true, true, richTextBox43.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W6ProgramStart", "W6ProgramEnd", true, true, richTextBox44.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W7ProgramStart", "W7ProgramEnd", true, true, richTextBox45.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W8ProgramStart", "W8ProgramEnd", true, true, richTextBox46.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W9ProgramStart", "W9ProgramEnd", true, true, richTextBox47.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W10ProgramStart", "W10ProgramEnd", true, true, richTextBox48.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W11ProgramStart", "W11ProgramEnd", true, true, richTextBox49.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W12ProgramStart", "W12ProgramEnd", true, true, richTextBox50.Text);
            myHtml = replaceBetweenWithoutRegex(myHtml, "W13ProgramStart", "W13ProgramEnd", true, true, richTextBox51.Text);


            //CONTRUBUTION LEVELS HERE
            //WEEK1
            if (checkBox91.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W11Start", "W11End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W12Start", "W12End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W13Start", "W13End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W14Start", "W14End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W15Start", "W15End", true, true, "");
            }
            else if (checkBox92.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W11Start", "W11End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W12Start", "W12End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W13Start", "W13End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W14Start", "W14End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W15Start", "W15End", true, true, "");
            }
            else if (checkBox93.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W11Start", "W11End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W12Start", "W12End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W13Start", "W13End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W14Start", "W14End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W15Start", "W15End", true, true, "");
            }
            else if (checkBox94.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W11Start", "W11End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W12Start", "W12End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W13Start", "W13End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W14Start", "W14End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W15Start", "W15End", true, true, "");
            }
            else if (checkBox95.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W11Start", "W11End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W12Start", "W12End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W13Start", "W13End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W14Start", "W14End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W15Start", "W15End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W11Start", "W11End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W12Start", "W12End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W13Start", "W13End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W14Start", "W14End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W15Start", "W15End", true, true, "");

            }

            //WEEK2

            if (checkBox96.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W21Start", "W21End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W22Start", "W22End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W23Start", "W23End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W24Start", "W24End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W25Start", "W25End", true, true, "");
            }
            else if (checkBox97.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W21Start", "W21End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W22Start", "W22End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W23Start", "W23End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W24Start", "W24End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W25Start", "W25End", true, true, "");

            }
            else if (checkBox98.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W21Start", "W21End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W22Start", "W22End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W23Start", "W23End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W24Start", "W24End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W25Start", "W25End", true, true, "");
            }
            else if (checkBox99.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W21Start", "W21End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W22Start", "W22End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W23Start", "W23End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W24Start", "W24End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W25Start", "W25End", true, true, "");
            }
            else if (checkBox100.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W21Start", "W21End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W22Start", "W22End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W23Start", "W23End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W24Start", "W24End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W25Start", "W25End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W21Start", "W21End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W22Start", "W22End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W23Start", "W23End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W24Start", "W24End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W25Start", "W25End", true, true, "");
            }
            //WEEK 3

            if (checkBox101.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W31Start", "W31End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W32Start", "W32End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W33Start", "W33End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W34Start", "W34End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W35Start", "W35End", true, true, "");
            }
            else if (checkBox102.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W31Start", "W31End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W32Start", "W32End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W33Start", "W33End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W34Start", "W34End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W35Start", "W35End", true, true, "");
            }
            else if (checkBox103.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W31Start", "W31End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W32Start", "W32End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W33Start", "W33End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W34Start", "W34End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W35Start", "W35End", true, true, "");
            }
            else if (checkBox104.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W31Start", "W31End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W32Start", "W32End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W33Start", "W33End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W34Start", "W34End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W35Start", "W35End", true, true, "");
            }
            else if (checkBox105.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W31Start", "W31End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W32Start", "W32End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W33Start", "W33End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W34Start", "W34End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W35Start", "W35End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W31Start", "W31End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W32Start", "W32End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W33Start", "W33End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W34Start", "W34End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W35Start", "W35End", true, true, "");
            }

            //WEEK 4

            if (checkBox106.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W41Start", "W41End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W42Start", "W42End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W43Start", "W43End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W44Start", "W44End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W45Start", "W45End", true, true, "");

            }
            else if (checkBox107.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W41Start", "W41End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W42Start", "W42End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W43Start", "W43End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W44Start", "W44End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W45Start", "W45End", true, true, "");
            }
            else if (checkBox108.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W41Start", "W41End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W42Start", "W42End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W43Start", "W43End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W44Start", "W44End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W45Start", "W45End", true, true, "");
            }
            else if (checkBox109.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W41Start", "W41End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W42Start", "W42End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W43Start", "W43End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W44Start", "W44End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W45Start", "W45End", true, true, "");
            }
            else if (checkBox110.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W41Start", "W41End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W42Start", "W42End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W43Start", "W43End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W44Start", "W44End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W45Start", "W45End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W41Start", "W41End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W42Start", "W42End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W43Start", "W43End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W44Start", "W44End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W45Start", "W45End", true, true, "");

            }

            //WEEK 5

            if (checkBox111.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W51Start", "W51End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W52Start", "W52End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W53Start", "W53End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W54Start", "W54End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W55Start", "W55End", true, true, "");
            }
            else if (checkBox112.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W51Start", "W51End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W52Start", "W52End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W53Start", "W53End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W54Start", "W54End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W55Start", "W55End", true, true, "");
            }
            else if (checkBox113.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W51Start", "W51End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W52Start", "W52End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W53Start", "W53End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W54Start", "W54End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W55Start", "W55End", true, true, "");
            }
            else if (checkBox114.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W51Start", "W51End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W52Start", "W52End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W53Start", "W53End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W54Start", "W54End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W55Start", "W55End", true, true, "");
            }
            else if (checkBox115.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W51Start", "W51End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W52Start", "W52End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W53Start", "W53End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W54Start", "W54End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W55Start", "W55End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W51Start", "W51End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W52Start", "W52End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W53Start", "W53End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W54Start", "W54End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W55Start", "W55End", true, true, "");
            }

            //WEEK 6

            if (checkBox116.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W61Start", "W61End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W62Start", "W62End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W63Start", "W63End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W64Start", "W64End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W65Start", "W65End", true, true, "");
            }
            else if (checkBox117.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W61Start", "W61End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W62Start", "W62End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W63Start", "W63End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W64Start", "W64End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W65Start", "W65End", true, true, "");
            }
            else if (checkBox118.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W61Start", "W61End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W62Start", "W62End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W63Start", "W63End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W64Start", "W64End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W65Start", "W65End", true, true, "");
            }
            else if (checkBox119.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W61Start", "W61End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W62Start", "W62End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W63Start", "W63End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W64Start", "W64End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W65Start", "W65End", true, true, "");
            }
            else if (checkBox120.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W61Start", "W61End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W62Start", "W62End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W63Start", "W63End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W64Start", "W64End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W65Start", "W65End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W61Start", "W61End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W62Start", "W62End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W63Start", "W63End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W64Start", "W64End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W65Start", "W65End", true, true, "");
            }

            //WEEK 7

            if (checkBox121.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W71Start", "W71End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W72Start", "W72End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W73Start", "W73End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W74Start", "W74End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W75Start", "W75End", true, true, "");
            }
            else if (checkBox122.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W71Start", "W71End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W72Start", "W72End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W73Start", "W73End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W74Start", "W74End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W75Start", "W75End", true, true, "");
            }
            else if (checkBox123.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W71Start", "W71End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W72Start", "W72End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W73Start", "W73End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W74Start", "W74End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W75Start", "W75End", true, true, "");
            }
            else if (checkBox124.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W71Start", "W71End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W72Start", "W72End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W73Start", "W73End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W74Start", "W74End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W75Start", "W75End", true, true, "");
            }
            else if (checkBox125.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W71Start", "W71End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W72Start", "W72End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W73Start", "W73End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W74Start", "W74End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W75Start", "W75End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W71Start", "W71End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W72Start", "W72End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W73Start", "W73End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W74Start", "W74End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W75Start", "W75End", true, true, "");
            }

            //WEEK 8

            if (checkBox126.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W81Start", "W81End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W82Start", "W82End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W83Start", "W83End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W84Start", "W84End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W85Start", "W85End", true, true, "");
            }
            else if (checkBox127.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W81Start", "W81End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W82Start", "W82End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W83Start", "W83End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W84Start", "W84End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W85Start", "W85End", true, true, "");
            }
            else if (checkBox128.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W81Start", "W81End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W82Start", "W82End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W83Start", "W83End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W84Start", "W84End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W85Start", "W85End", true, true, "");
            }
            else if (checkBox129.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W81Start", "W81End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W82Start", "W82End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W83Start", "W83End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W84Start", "W84End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W85Start", "W85End", true, true, "");
            }
            else if (checkBox130.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W81Start", "W81End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W82Start", "W82End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W83Start", "W83End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W84Start", "W84End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W85Start", "W85End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W81Start", "W81End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W82Start", "W82End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W83Start", "W83End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W84Start", "W84End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W85Start", "W85End", true, true, "");
            }

            //WEEK 9

            if (checkBox131.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W91Start", "W91End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W92Start", "W92End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W93Start", "W93End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W94Start", "W94End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W95Start", "W95End", true, true, "");
            }
            else if (checkBox132.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W91Start", "W91End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W92Start", "W92End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W93Start", "W93End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W94Start", "W94End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W95Start", "W95End", true, true, "");
            }
            else if (checkBox133.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W91Start", "W91End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W92Start", "W92End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W93Start", "W93End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W94Start", "W94End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W95Start", "W95End", true, true, "");
            }
            else if (checkBox134.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W91Start", "W91End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W92Start", "W92End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W93Start", "W93End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W94Start", "W94End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W95Start", "W95End", true, true, "");
            }
            else if (checkBox135.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W91Start", "W91End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W92Start", "W92End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W93Start", "W93End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W94Start", "W94End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W95Start", "W95End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W91Start", "W91End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W92Start", "W92End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W93Start", "W93End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W94Start", "W94End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W95Start", "W95End", true, true, "");
            }

            //WEEK 10

            if (checkBox136.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W101Start", "W101End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W102Start", "W102End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W103Start", "W103End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W104Start", "W104End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W105Start", "W105End", true, true, "");
            }
            else if (checkBox137.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W101Start", "W101End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W102Start", "W102End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W103Start", "W103End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W104Start", "W104End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W105Start", "W105End", true, true, "");
            }
            else if (checkBox138.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W101Start", "W101End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W102Start", "W102End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W103Start", "W103End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W104Start", "W104End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W105Start", "W105End", true, true, "");
            }
            else if (checkBox139.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W101Start", "W101End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W102Start", "W102End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W103Start", "W103End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W104Start", "W104End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W105Start", "W105End", true, true, "");
            }
            else if (checkBox140.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W101Start", "W101End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W102Start", "W102End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W103Start", "W103End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W104Start", "W104End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W105Start", "W105End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W101Start", "W101End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W102Start", "W102End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W103Start", "W103End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W104Start", "W104End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W105Start", "W105End", true, true, "");
            }

            //WEEK 11

            if (checkBox141.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W111Start", "W111End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W112Start", "W112End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W113Start", "W113End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W114Start", "W114End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W115Start", "W115End", true, true, "");
            }
            else if (checkBox142.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W111Start", "W111End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W112Start", "W112End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W113Start", "W113End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W114Start", "W114End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W115Start", "W115End", true, true, "");
            }
            else if (checkBox143.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W111Start", "W111End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W112Start", "W112End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W113Start", "W113End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W114Start", "W114End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W115Start", "W115End", true, true, "");
            }
            else if (checkBox144.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W111Start", "W111End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W112Start", "W112End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W113Start", "W113End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W114Start", "W114End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W115Start", "W115End", true, true, "");
            }
            else if (checkBox145.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W111Start", "W111End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W112Start", "W112End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W113Start", "W113End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W114Start", "W114End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W115Start", "W115End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W111Start", "W111End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W112Start", "W112End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W113Start", "W113End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W114Start", "W114End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W115Start", "W115End", true, true, "");
            }

            //WEEK 12

            if (checkBox146.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W121Start", "W121End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W122Start", "W122End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W123Start", "W123End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W124Start", "W124End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W125Start", "W125End", true, true, "");
            }
            else if (checkBox147.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W121Start", "W121End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W122Start", "W122End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W123Start", "W123End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W124Start", "W124End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W125Start", "W125End", true, true, "");
            }
            else if (checkBox148.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W121Start", "W121End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W122Start", "W122End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W123Start", "W123End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W124Start", "W124End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W125Start", "W125End", true, true, "");
            }
            else if (checkBox149.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W121Start", "W121End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W122Start", "W122End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W123Start", "W123End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W124Start", "W124End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W125Start", "W125End", true, true, "");
            }
            else if (checkBox150.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W121Start", "W121End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W122Start", "W122End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W123Start", "W123End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W124Start", "W124End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W125Start", "W125End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W121Start", "W121End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W122Start", "W122End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W123Start", "W123End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W124Start", "W124End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W125Start", "W125End", true, true, "");
            }

            //WEEK 13

            if (checkBox151.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W131Start", "W131End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W132Start", "W132End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W133Start", "W133End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W134Start", "W134End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W135Start", "W135End", true, true, "");
            }
            else if (checkBox152.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W131Start", "W131End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W132Start", "W132End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W133Start", "W133End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W134Start", "W134End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W135Start", "W135End", true, true, "");
            }
            else if (checkBox153.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W131Start", "W131End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W132Start", "W132End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W133Start", "W133End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W134Start", "W134End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W135Start", "W135End", true, true, "");
            }
            else if (checkBox154.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W131Start", "W131End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W132Start", "W132End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W133Start", "W133End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W134Start", "W134End", true, true, "X");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W135Start", "W135End", true, true, "");
            }
            else if (checkBox155.Checked)
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W131Start", "W131End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W132Start", "W132End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W133Start", "W133End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W134Start", "W134End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W135Start", "W135End", true, true, "X");
            }
            else
            {
                myHtml = replaceBetweenWithoutRegex(myHtml, "W131Start", "W131End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W132Start", "W132End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W133Start", "W133End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W134Start", "W134End", true, true, "");
                myHtml = replaceBetweenWithoutRegex(myHtml, "W135Start", "W135End", true, true, "");
            }



















            WriteToFile(myHtml, "last_save.html");


            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası|*.html";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.WriteLine(myHtml);
                Kayit.Close();
            }


        }

        public static void WriteToFile(string s, string fileName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Append, System.IO.FileAccess.Write);
            StreamWriter sw = new System.IO.StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        private void textBox296_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox70_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            editPanel2.Show();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "last_save.html");
            WebClient client = new WebClient();
            String myHtml = client.DownloadString(path);

            byte[] bytes = Encoding.Default.GetBytes(myHtml);
            myHtml = Encoding.UTF8.GetString(bytes);

            string[] separatingStrings = { "tr>" };

            string text = myHtml;

            string[] lines = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);


            int cnt = 0;
            foreach (var line in lines)
            {
                System.Console.WriteLine(cnt);
                System.Console.WriteLine(line);
                cnt += 1;
            }

            

            textBox304.Text = ExtractString(GetLine(lines[1], 3), ">", "<").Trim();
            textBox306.Text = ExtractString(GetLine(lines[7], 2), ">", "<").Trim();
            if (ExtractString(GetLine(lines[7], 3), ">", "<").Trim() == "X")
            {
                checkBox20.Checked = true;
            }
            if (ExtractString(GetLine(lines[7], 4), ">", "<").Trim() == "X")
            {
                checkBox19.Checked = true;
            }

            

            textBox307.Text = ExtractString(GetLine(lines[7], 5), ">", "<").Trim();
            textBox308.Text = ExtractString(GetLine(lines[7], 6), ">", "<").Trim();
            textBox305.Text = ExtractString(GetLine(lines[7], 7), ">", "<").Trim();
            textBox309.Text = ExtractString(GetLine(lines[7], 8), ">", "<").Trim();
            textBox303.Text = ExtractString(GetLine(lines[9], 3), ">", "<").Trim();

            if (ExtractString(GetLine(lines[11], 3), ">", "<").Trim() == "İngilizce" || ExtractString(GetLine(lines[11], 3), ">", "<").Trim() == "English")
            {
                checkBox7.Checked = true;
            }
            else
            {
                checkBox8.Checked = true;
            }


            if (ExtractString(GetLine(lines[13], 3), ">", "<").Trim() == "Required" || ExtractString(GetLine(lines[13], 3), ">", "<").Trim() == "Zorunlu")
            {
                checkBox13.Checked = true;
            }
            else
            {
                checkBox14.Checked = true;
            }

            if (ExtractString(GetLine(lines[15], 3), ">", "<").Trim() == "First Cycle" || ExtractString(GetLine(lines[15], 3), ">", "<").Trim() == "Lisans")
            {
                checkBox16.Checked = true;
            }
            else if (ExtractString(GetLine(lines[15], 3), ">", "<").Trim() == "Short Cycle" || ExtractString(GetLine(lines[15], 3), ">", "<").Trim() == "Ön Lisans")
            {
                checkBox15.Checked = true;
            }
            else if (ExtractString(GetLine(lines[15], 3), ">", "<").Trim() == "Second Cycle" || ExtractString(GetLine(lines[15], 3), ">", "<").Trim() == "Yüksek Lisans")
            {
                checkBox17.Checked = true;
            }
            else if (ExtractString(GetLine(lines[15], 3), ">", "<").Trim() == "Third Cycle" || ExtractString(GetLine(lines[15], 3), ">", "<").Trim() == "Doktora")
            {
                checkBox18.Checked = true;
            }

            textBox97.Text = ExtractString(GetLine(lines[17], 3), ">", "<").Trim();
            textBox98.Text = ExtractString(GetLine(lines[19], 3), ">", "<").Trim();
            textBox99.Text = ExtractString(GetLine(lines[21], 3), ">", "<").Trim();
            richTextBox37.Text = ExtractString(GetLine(lines[23], 3), ">", "<").Trim();
            richTextBox38.Text = ExtractString(GetLine(lines[25], 3), ">", "<").Trim();
            richTextBox39.Text = ExtractString(GetLine(lines[27], 3), ">", "<").Trim();

            


            if (ExtractString(GetLine(lines[30], 3), ">", "<").Trim() == "Core Course" || ExtractString(GetLine(lines[30], 3), ">", "<").Trim() == "Temel Ders")
            {
                checkBox86.Checked = true;
            }
            else if (ExtractString(GetLine(lines[32], 3), ">", "<").Trim() == "Major Area Course" || ExtractString(GetLine(lines[32], 3), ">", "<").Trim() == "Uzmanlık/Alan Ders")
            {
                checkBox87.Checked = true;
            }
            else if (ExtractString(GetLine(lines[34], 3), ">", "<").Trim() == "Supportive Course" || ExtractString(GetLine(lines[34], 3), ">", "<").Trim() == "Destek Dersi")
            {
                checkBox88.Checked = true;
            }
            else if (ExtractString(GetLine(lines[36], 3), ">", "<").Trim() == "Communication and Management Skills Course" || ExtractString(GetLine(lines[36], 3), ">", "<").Trim() == "İletişim ve Yönetim Becerileri Dersi")
            {
                checkBox89.Checked = true;
            }
            else if (ExtractString(GetLine(lines[38], 3), ">", "<").Trim() == "Transferable Skill Course" || ExtractString(GetLine(lines[38], 3), ">", "<").Trim() == "Aktarılabilir Beceri Dersi")
            {
                checkBox90.Checked = true;
            }

            richTextBox2.Text = ExtractString(GetLine(lines[43], 3), ">", "<").Trim();
            richTextBox3.Text = ExtractString(GetLine(lines[43], 4), ">", "<").Trim();
            richTextBox4.Text = ExtractString(GetLine(lines[45], 3), ">", "<").Trim();
            richTextBox5.Text = ExtractString(GetLine(lines[45], 4), ">", "<").Trim();
            richTextBox6.Text = ExtractString(GetLine(lines[47], 3), ">", "<").Trim();
            richTextBox7.Text = ExtractString(GetLine(lines[47], 4), ">", "<").Trim();
            richTextBox8.Text = ExtractString(GetLine(lines[49], 3), ">", "<").Trim();
            richTextBox9.Text = ExtractString(GetLine(lines[49], 4), ">", "<").Trim();
            richTextBox10.Text = ExtractString(GetLine(lines[51], 3), ">", "<").Trim();
            richTextBox11.Text = ExtractString(GetLine(lines[51], 4), ">", "<").Trim();
            richTextBox12.Text = ExtractString(GetLine(lines[53], 3), ">", "<").Trim();
            richTextBox13.Text = ExtractString(GetLine(lines[53], 4), ">", "<").Trim();
            richTextBox14.Text = ExtractString(GetLine(lines[55], 3), ">", "<").Trim();
            richTextBox15.Text = ExtractString(GetLine(lines[55], 4), ">", "<").Trim();
            richTextBox16.Text = ExtractString(GetLine(lines[57], 3), ">", "<").Trim();
            richTextBox17.Text = ExtractString(GetLine(lines[57], 4), ">", "<").Trim();
            richTextBox18.Text = ExtractString(GetLine(lines[59], 3), ">", "<").Trim();
            richTextBox19.Text = ExtractString(GetLine(lines[59], 4), ">", "<").Trim();
            richTextBox20.Text = ExtractString(GetLine(lines[61], 3), ">", "<").Trim();
            richTextBox21.Text = ExtractString(GetLine(lines[61], 4), ">", "<").Trim();
            richTextBox22.Text = ExtractString(GetLine(lines[63], 3), ">", "<").Trim();
            richTextBox23.Text = ExtractString(GetLine(lines[63], 4), ">", "<").Trim();
            richTextBox24.Text = ExtractString(GetLine(lines[65], 3), ">", "<").Trim();
            richTextBox25.Text = ExtractString(GetLine(lines[65], 4), ">", "<").Trim();
            richTextBox26.Text = ExtractString(GetLine(lines[67], 3), ">", "<").Trim();
            richTextBox27.Text = ExtractString(GetLine(lines[67], 4), ">", "<").Trim();
            richTextBox28.Text = ExtractString(GetLine(lines[69], 3), ">", "<").Trim();
            richTextBox29.Text = ExtractString(GetLine(lines[69], 4), ">", "<").Trim();
            richTextBox30.Text = ExtractString(GetLine(lines[71], 3), ">", "<").Trim();
            richTextBox31.Text = ExtractString(GetLine(lines[71], 4), ">", "<").Trim();
            richTextBox32.Text = ExtractString(GetLine(lines[73], 3), ">", "<").Trim();
            richTextBox33.Text = ExtractString(GetLine(lines[73], 4), ">", "<").Trim();

            richTextBox40.Text = ExtractString(GetLine(lines[75], 3), ">", "<").Trim();
            richTextBox41.Text = ExtractString(GetLine(lines[77], 3), ">", "<").Trim();

           

            textBox94.Text = ExtractString(GetLine(lines[81], 3), ">", "<").Trim();
            textBox93.Text = ExtractString(GetLine(lines[81], 4), ">", "<").Trim();

            textBox92.Text = ExtractString(GetLine(lines[83], 3), ">", "<").Trim();
            textBox91.Text = ExtractString(GetLine(lines[83], 4), ">", "<").Trim();

            textBox90.Text = ExtractString(GetLine(lines[85], 3), ">", "<").Trim();
            textBox89.Text = ExtractString(GetLine(lines[85], 4), ">", "<").Trim();

            textBox88.Text = ExtractString(GetLine(lines[87], 3), ">", "<").Trim();
            textBox87.Text = ExtractString(GetLine(lines[87], 4), ">", "<").Trim();

            textBox86.Text = ExtractString(GetLine(lines[89], 3), ">", "<").Trim();
            textBox85.Text = ExtractString(GetLine(lines[89], 4), ">", "<").Trim();

            textBox84.Text = ExtractString(GetLine(lines[91], 3), ">", "<").Trim();
            textBox83.Text = ExtractString(GetLine(lines[91], 4), ">", "<").Trim();

            textBox82.Text = ExtractString(GetLine(lines[93], 3), ">", "<").Trim();
            textBox81.Text = ExtractString(GetLine(lines[93], 4), ">", "<").Trim();

            textBox80.Text = ExtractString(GetLine(lines[95], 3), ">", "<").Trim();
            textBox79.Text = ExtractString(GetLine(lines[95], 4), ">", "<").Trim();

            textBox78.Text = ExtractString(GetLine(lines[97], 3), ">", "<").Trim();
            textBox77.Text = ExtractString(GetLine(lines[97], 4), ">", "<").Trim();

            textBox76.Text = ExtractString(GetLine(lines[99], 3), ">", "<").Trim();
            textBox75.Text = ExtractString(GetLine(lines[99], 4), ">", "<").Trim();

            textBox74.Text = ExtractString(GetLine(lines[101], 3), ">", "<").Trim();
            textBox73.Text = ExtractString(GetLine(lines[101], 4), ">", "<").Trim();

            textBox95.Text = ExtractString(GetLine(lines[103], 3), ">", "<").Trim();
            textBox96.Text = ExtractString(GetLine(lines[103], 4), ">", "<").Trim();

            

            textBox194.Text = ExtractString(GetLine(lines[105], 3), ">", "<").Trim();
            textBox195.Text = ExtractString(GetLine(lines[105], 4), ">", "<").Trim();

            textBox196.Text = ExtractString(GetLine(lines[107], 3), ">", "<").Trim();
            textBox193.Text = ExtractString(GetLine(lines[107], 3), ">", "<").Trim();




            // ECTS PART
            textBox152.Text = ExtractString(GetLine(lines[111], 3), ">", "<").Trim();
            textBox153.Text = ExtractString(GetLine(lines[111], 4), ">", "<").Trim();
            textBox151.Text = ExtractString(GetLine(lines[111], 5), ">", "<").Trim();

            textBox154.Text = ExtractString(GetLine(lines[113], 3), ">", "<").Trim();
            textBox155.Text = ExtractString(GetLine(lines[113], 4), ">", "<").Trim();
            textBox156.Text = ExtractString(GetLine(lines[113], 5), ">", "<").Trim();

            textBox157.Text = ExtractString(GetLine(lines[114], 3), ">", "<").Trim();
            textBox159.Text = ExtractString(GetLine(lines[114], 4), ">", "<").Trim();
            textBox160.Text = ExtractString(GetLine(lines[114], 5), ">", "<").Trim();

            textBox161.Text = ExtractString(GetLine(lines[116], 3), ">", "<").Trim();
            textBox163.Text = ExtractString(GetLine(lines[116], 4), ">", "<").Trim();
            textBox164.Text = ExtractString(GetLine(lines[116], 5), ">", "<").Trim();

            textBox171.Text = ExtractString(GetLine(lines[118], 3), ">", "<").Trim();
            textBox175.Text = ExtractString(GetLine(lines[118], 4), ">", "<").Trim();
            textBox170.Text = ExtractString(GetLine(lines[118], 5), ">", "<").Trim();

            textBox171.Text = ExtractString(GetLine(lines[120], 3), ">", "<").Trim();
            textBox175.Text = ExtractString(GetLine(lines[120], 4), ">", "<").Trim();
            textBox179.Text = ExtractString(GetLine(lines[120], 5), ">", "<").Trim();


            textBox176.Text = ExtractString(GetLine(lines[122], 3), ">", "<").Trim();
            textBox177.Text = ExtractString(GetLine(lines[122], 4), ">", "<").Trim();
            textBox181.Text = ExtractString(GetLine(lines[122], 5), ">", "<").Trim();


            textBox182.Text = ExtractString(GetLine(lines[124], 3), ">", "<").Trim();
            textBox183.Text = ExtractString(GetLine(lines[124], 4), ">", "<").Trim();
            textBox184.Text = ExtractString(GetLine(lines[124], 5), ">", "<").Trim();


            textBox185.Text = ExtractString(GetLine(lines[126], 3), ">", "<").Trim();
            textBox186.Text = ExtractString(GetLine(lines[126], 4), ">", "<").Trim();
            textBox187.Text = ExtractString(GetLine(lines[126], 5), ">", "<").Trim(); 


            textBox150.Text = ExtractString(GetLine(lines[128], 3), ">", "<").Trim();
            textBox188.Text = ExtractString(GetLine(lines[128], 4), ">", "<").Trim();
            textBox189.Text = ExtractString(GetLine(lines[128], 5), ">", "<").Trim();


            textBox149.Text = ExtractString(GetLine(lines[130], 3), ">", "<").Trim();
            textBox148.Text = ExtractString(GetLine(lines[130], 4), ">", "<").Trim();
            textBox190.Text = ExtractString(GetLine(lines[130], 5), ">", "<").Trim();


            textBox147.Text = ExtractString(GetLine(lines[132], 3), ">", "<").Trim();
            textBox146.Text = ExtractString(GetLine(lines[132], 4), ">", "<").Trim();
            textBox191.Text = ExtractString(GetLine(lines[132], 5), ">", "<").Trim();

            textBox192.Text = ExtractString(GetLine(lines[134], 5), ">", "<").Trim();













            



            
            richTextBox34.Text = ExtractString(GetLine(lines[140], 3), ">", "<").Trim();
            richTextBox35.Text = ExtractString(GetLine(lines[142], 3), ">", "<").Trim();
            richTextBox36.Text = ExtractString(GetLine(lines[144], 3), ">", "<").Trim();
            richTextBox42.Text = ExtractString(GetLine(lines[146], 3), ">", "<").Trim();
            richTextBox43.Text = ExtractString(GetLine(lines[148], 3), ">", "<").Trim();
            richTextBox44.Text = ExtractString(GetLine(lines[150], 3), ">", "<").Trim();
            richTextBox45.Text = ExtractString(GetLine(lines[152], 3), ">", "<").Trim();
            richTextBox46.Text = ExtractString(GetLine(lines[154], 3), ">", "<").Trim();
            richTextBox47.Text = ExtractString(GetLine(lines[156], 3), ">", "<").Trim();
            richTextBox48.Text = ExtractString(GetLine(lines[158], 3), ">", "<").Trim();
            richTextBox49.Text = ExtractString(GetLine(lines[160], 3), ">", "<").Trim();
            richTextBox50.Text = ExtractString(GetLine(lines[162], 3), ">", "<").Trim();
            richTextBox51.Text = ExtractString(GetLine(lines[164], 3), ">", "<").Trim();








        }




    }
}

