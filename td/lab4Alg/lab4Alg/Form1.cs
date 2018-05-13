using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4Alg {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Tree T;

        private void but_Add_Click(object sender, EventArgs e) {

            string skrName, name, kl, txt_search;
            skrName = text_skr.Text;
            name = text_inf.Text;
            kl = text_key.Text;
            txt_search = text_task.Text;
            try {
                InfElem elem = new InfElem(skrName, name, kl);
                T.Add_Node(txt_search, elem);
            }catch(MyExcept ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void butCreate_Click(object sender, EventArgs e) {
            string skrName, name, kl;
            skrName = text_skr.Text;
            name = text_inf.Text;
            kl = text_key.Text;
            if(kl == "" || name == "" || skrName == "") {
                MessageBox.Show("Вы не заполнили все поля!");
                return;
            }
            InfElem elem = new InfElem(skrName, name, kl);
            T = new Tree(elem);
            textBox_test.Clear();
        }

        private void but_Show_Click(object sender, EventArgs e) {
            textBox_test.Clear();
            T.ShowIPD(T.r, " ", textBox_test);
        }

        private void but_Find_Click(object sender, EventArgs e) {
            string find = text_task.Text;
            try {
                ElemTree elem = T.FindNode(T.r, find);
                text_skr.Text = elem.D.sokrName;
                text_inf.Text = elem.D.name;       // выделенного 
                text_key.Text = elem.D.kl;
            } catch (MyExcept ex) {
                MessageBox.Show(ex.Message);
            } catch (NullReferenceException) {
                MessageBox.Show("Некорректный ключ или дерево пустое!");
            } catch (Exception ex1) {
                MessageBox.Show(ex1.Message);
            }

        }

        private void but_edit_Click(object sender, EventArgs e) {
            string skrName, name, kl;
            skrName = text_skr.Text;
            name = text_inf.Text;
            kl = text_key.Text;
            try {
                InfElem elem = new InfElem(skrName, name, kl);
                T.EditNode(text_key.Text, elem);
            } catch (MyExcept ex) {
                MessageBox.Show(ex.Message);
            } catch (Exception ex1) {
                MessageBox.Show(ex1.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string kl, kl_pot;

            try {
                
                kl = text_key.Text;
                kl_pot = text_task.Text;
                T.DellNode(kl_pot, kl);
            } catch (MyExcept ex) {
                MessageBox.Show(ex.Message);
            } 
        }

        private void button2_Click(object sender, EventArgs e) {
            T.DellTree();
            MessageBox.Show("Дерево удалено!");
        }

        private void button3_Click(object sender, EventArgs e) {
            try {
                T.ShowNode(T.r, text_key.Text);
            } catch (MyExcept ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
    }

    public class MyExcept : ApplicationException {
        public MyExcept(string msg) : base(msg) { }
    }

    public class InfElem {
        public string sokrName;
        public string name;
        public string kl;

        public InfElem() : base() {}

        public InfElem(string sokrName, string name, string kl) {
            this.sokrName = sokrName;
            this.name = name;
            this.kl = kl;
        }
    }

    public class ElemTree {
        public ElemTree FL;
        public ElemTree FR;
        public InfElem D;

        public ElemTree() : base() {}

        public ElemTree(InfElem d) {
            this.D = d;
            this.FL = null;
            this.FR = null;
        }
    }

    public class Tree {
        public ElemTree r;
 
        public Tree() : base() { }

        public Tree(InfElem inf) {
            r = new ElemTree(inf);
        }

        public void Add_Node(string Tkey, InfElem Tinf) {
            ElemTree elem = FindNode(r, Tkey);

            if (elem == null) throw new MyExcept("Узел с таким ключем не найден!");

            if (elem.FL == null) {
                elem.FL = new ElemTree(Tinf);
            } else {
                ElemTree temp = elem.FL;
                while (temp.FR != null) {
                    temp = temp.FR;
                }
                temp.FR = new ElemTree(Tinf);
            }
        }


        public void DellNode(string kl_rod, string kl_pot) {  // удалить у родителя потомка

            ElemTree elem = FindNode(r, kl_rod);
            if (elem == null) throw new MyExcept("Родительский узел с таким ключем не найден!");
            ElemTree potom = FindNode(elem, kl_pot);
            if (potom == null) throw new MyExcept("Потомок с таким ключем не найден!");
            if (elem.FL == null) throw new MyExcept("В данного родителя нет потомков");

            if (elem.FL.D.kl == kl_pot) {
                elem.FL = elem.FL.FR;
            } else {
                ElemTree temp = elem.FL;
                while (temp != null && temp.FR?.D?.kl != kl_pot) {
                    temp = temp?.FR;
                }
                if (temp?.FR == null) {
                    throw new MyExcept("В данного узла нет потомка с таким ключом");
                } else {
                    temp.FR = temp.FR.FR;
                }     
            }
        }


        public void EditNode(string kl, InfElem infEl) {

            if (infEl.kl != kl) throw new MyExcept("Ошибка! Разные ключи!");
            ElemTree elem = FindNode(r, kl);
            if (elem == null) throw new MyExcept("Узел с таким ключем не найден!");
            elem.D.sokrName = infEl.sokrName;
            elem.D.name = infEl.name;
        }


        public void DellTree() {
            if (r == null) return;
            r = null;
        }

        public ElemTree ShowNode(ElemTree R, string Tkey) {

            ElemTree elem = FindNode(R, Tkey);
            if (elem == null) throw new MyExcept("Узел с таким ключем не найден!");
            MessageBox.Show("Сокращенное имя: " + elem.D.sokrName + ". \nИмя: " + elem.D.name + ". \nКлюч: " + elem.D.kl);
            return elem;
        }

        // Рекурсивный поиск
        public ElemTree FindNode(ElemTree R, string kl) {

            if (R != null) {
                // R
                if (R.D.kl == kl)
                    return R;
                // A
                ElemTree p = FindNode(R.FL, kl);
                if (p != null)
                    return p;
                // B
                return p = FindNode(R.FR, kl);
            }
            return null;
        }

        // Итерационный вывод
        struct EtSt {
            public ElemTree et;
            public string s;
            public EtSt(ElemTree et, string s) {
                this.et = et;
                this.s = s;
            }
        }

        public void ShowIPD(ElemTree R, string S, TextBox tb) {
            EtSt[] A = new EtSt[50]; // А - стек для хранения узлов дерева 
            int st = -1;      // st – начало стека (стек пустой)
            ElemTree p = R;   // p – текущая ссылка на узел дерева
            string ps = S;    // ps – текущий сдвиг
            EtSt es;

            m: while (p != null) {
                tb.AppendText(ps + p.D.sokrName + "\r\n");// вывод узла p //R
                st++;                          //инкрем. Стека
                es = new EtSt(p, ps);
                A[st] = es;                    // запись текущего узла
                p = p.FL;
                if (p != null) {
                    ps += "   ";   // сдвиг увеличиваем т.к. идем по ссылке  FL
                }
            }

            if (st == -1) return;
            p = A[st].et;       //извлечение из стека нового узла 
            ps = A[st].s;
            st = st - 1;        //декремент стека
            p = p.FR;
            goto m;
        }
    }
}


