using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Which_Programing_Should_I_Learn
{
    public partial class frmMain : Form
    {
        List<MyQuestion> questionList = new List<MyQuestion>();
        private Stack<MyAnswer> myAnswers = new Stack<MyAnswer>();
        private Dictionary<String, String> description = new Dictionary<string, string>();
        private int currentQuestion = -1;
        private List<String> key = new List<string>()
        {
            "why", "which_platform", "which_mobile_os", "web", "want_to_work_for",
            "think_about_microsoft", "try_something_new", "favourite_toy",
            "prefer_to_learn", "car"
        };
        private MyProlog prolog;
        private const String prologFilePath = @"..\..\Prolog_Code.pl";
        public frmMain()
        {
            InitializeComponent();
            // Init & Load prolog file
            prolog = new MyProlog();
            prolog.LoadFile(prologFilePath);
            // Build List question
            buildListQuestion();
        }

        private void buildListQuestion()
        {
            // 0
            questionList.Add(new MyQuestion("Why do you want to learn programming?", 
                new List<string>() { "For my kids", "I don't know", "Make money",
                "Just for fun", "I'm interested", "Improve myself"}));
            // 1
            questionList.Add(new MyQuestion("Which platform/field?", 
                new List<string>() { "Doesn't matter", "Gamming", "Mobile", "Facebook",
                "Google", "Microsoft", "Apple", "Web", "Enterprise"}));
            // 2
            questionList.Add(new MyQuestion("Which OS?", new List<string>() { "IOS", "Android" }));
            // 3
            questionList.Add(new MyQuestion("Which \"end\"?", new List<string>() { "Front end", "Back end" }));
            // 4
            questionList.Add(new MyQuestion("I want to work for...", new List<string>() { "Startup", "Corporate" }));
            // 5
            questionList.Add(new MyQuestion("What do you think about Microsoft?", 
                new List<string>() { "I'm a fan", "Not bad", "Suck" }));
            // 6
            questionList.Add(new MyQuestion("Do you want to try something new, with huge potential, but less mature?", 
                new List<string>() { "Yes", "No" }));
            // 7
            questionList.Add(new MyQuestion("Which one is your favourite toy?", 
                new List<string>() { "Lego", "Play doh", "Old ugly" }));
            // 8
            questionList.Add(new MyQuestion("I prefer to learn things...", 
                new List<string>() { "Easy way", "Best way", "Harder way", "Hardest way" }));
            // 9
            questionList.Add(new MyQuestion("Auto or Manual car?", 
                new List<string>() { "Auto", "Manual" }));

            description.Add("PYTHON", "PYTHON is the right for you! \nWidely regarded as the best programming language for beginners\nEasiest to learn");
            description.Add("JAVA", "JAVA is the right for you!\nOne of the most in demand & highest paying programming languages\nSlogan: write once, work everywhere");
            description.Add("C", "C is the right for you!\nLingua franca of programming language\nOne of the oldest and most widely used language in the world");
            description.Add("C++", "C++ is the right for you!\nComplex version of C with a lot more features\nRecommended only if you have a mentor to guide you");
            description.Add("JAVASCRIPT", "JAVASCRIPT is the right for you!\nMost popular clients-side web scripting language\nA must learn for front-end web developer (HTML and CSS as well)");
            description.Add("C#", "C# is the right for you!\nA popular choice for enterprise to create websites and Windows application using .NET framework\nSimilar to Java in basic syntax and some features");
            description.Add("RUBY", "RUBY is the right for you!\nMostly known for its popular web framework, Ruby on Rails\nFocuses on getting things done");
            description.Add("PHP", "PHP is the right for you!\nSuitable for building small and simple sites within a short time frame\nSupported by almost every web hosting services with lower price");
            description.Add("OBJECTIVE-C", "OBJECTIVE-C is the right for you!\nPrimary language used by Apple for MacOSX & iOS\nChoose this if you want to focus on developing iOS or OSX apps only");
        }

        private void BindQuestion(int index)
        {
            HideRadioButton();
            lbQuestion.Text = questionList[index].Question;
            for(int i = 0; i < questionList[index].Answers.Count; i++)
            {
                RadioButton c = (RadioButton)this.Controls.Find("rd" + (i + 1), true).FirstOrDefault();
                c.Text = questionList[index].Answers[i];
                c.Visible = true;
            }
        }

        private int QuestionControl(int index, String ans)
        {
            int current = -1;
            switch (index)
            {
                case 0:
                    if (ans.Equals("make_money")) { BindQuestion(1); current = 1; }
                    else if (ans.Equals("just_for_fun") || ans.Equals("im_interested") || ans.Equals("improve_myself")) { BindQuestion(8); current = 8; }
                    break;
                case 1:
                    if (ans.Equals("mobile")) { BindQuestion(2); current = 2; }
                    else if (ans.Equals("web")) { BindQuestion(3); current = 3; }
                    else if (ans.Equals("enterprise")) { BindQuestion(5); current = 5; }
                    break;
                case 2:
                    break;
                case 3:
                    if(ans.Equals("back_end")) { BindQuestion(4); current = 4; }
                    break;
                case 4:
                    if(ans.Equals("startup")) { BindQuestion(6); current = 6; }
                    else if(ans.Equals("corporate")) { BindQuestion(5); current = 5; }
                    break;
                case 5:
                    break;
                case 6:
                    if(ans.Equals("no")) { BindQuestion(7); current = 7; }
                    break;
                case 7:
                    break;
                case 8:
                    if(ans.Equals("harder_way")) { BindQuestion(9); current = 9; }
                    break;
                case 9:
                    break;
            }
            return current;
        }

        private String GetResult(String ans)
        {
            return ans.Replace(" ", "_").Replace("'","").ToLower();
        }

        private void HideRadioButton()
        {
            rd1.Visible = false;
            rd2.Visible = false;
            rd3.Visible = false;
            rd4.Visible = false;
            rd5.Visible = false;
            rd6.Visible = false;
            rd7.Visible = false;
            rd8.Visible = false;
            rd9.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            gpQuestion.Visible = true;
            lbTitle.Location = new Point(lbTitle.Location.X, lbTitle.Location.Y - 115);
            currentQuestion = 0;
            BindQuestion(0);
        }
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            btnStart.Visible = true;
            gpQuestion.Visible = false;
            lbTitle.Location = new Point(lbTitle.Location.X, lbTitle.Location.Y + 115);
            myAnswers.Clear();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rd1.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd1.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd1.Text)); }
            else if(rd2.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd2.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd2.Text)); }
            else if(rd3.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd3.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd3.Text)); }
            else if(rd4.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd4.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd4.Text)); }
            else if(rd5.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd5.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd5.Text)); }
            else if(rd6.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd6.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd6.Text)); }
            else if(rd7.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd7.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd7.Text)); }
            else if(rd8.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd8.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd8.Text)); }
            else if(rd9.Checked) { myAnswers.Push(new MyAnswer(currentQuestion, GetResult(rd9.Text))); currentQuestion = QuestionControl(currentQuestion, GetResult(rd9.Text)); }
            if(currentQuestion == -1)
            {
                String query = "";
                while(myAnswers.Count > 0)
                {
                    MyAnswer ma = myAnswers.Pop();
                    query = key[ma.QuestionIndex] + "('" + ma.Answer + "'), " + query;
                }
                query = query.Substring(0, query.Length - 2);
                query = "language(X, " + query + ").";
                MessageBox.Show(description[prolog.GetResult(query).ToUpper()], "Hey!!!",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(myAnswers.Count > 0)
            {
                currentQuestion = myAnswers.Peek().QuestionIndex;
                BindQuestion(currentQuestion);
                myAnswers.Pop();
            }
            else
            {
                
            }
        }
    }
}
