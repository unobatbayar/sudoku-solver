using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sudokusolver
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Solve_Sudoku(object sender, System.EventArgs e)
        {
            Sudoku sudoku = new Sudoku(Grid_toInt());
            sudoku.solveSudoku();
            int[][] solvedSudokuGrid = sudoku.getSudokuGrid();
            updateGrid(solvedSudokuGrid);
        }

        void updateGrid(int[][] solvedSudokuGrid){
            
            Maa.Text = System.Convert.ToString(solvedSudokuGrid[0][0]);
            Mab.Text = System.Convert.ToString(solvedSudokuGrid[0][1]);
            Mac.Text = System.Convert.ToString(solvedSudokuGrid[0][2]);
            Mad.Text = System.Convert.ToString(solvedSudokuGrid[0][3]);
            Mae.Text = System.Convert.ToString(solvedSudokuGrid[0][4]);
            Maf.Text = System.Convert.ToString(solvedSudokuGrid[0][5]);
            Mag.Text = System.Convert.ToString(solvedSudokuGrid[0][6]);
            Mah.Text = System.Convert.ToString(solvedSudokuGrid[0][7]);
            Mai.Text = System.Convert.ToString(solvedSudokuGrid[0][8]);

            Mba.Text = System.Convert.ToString(solvedSudokuGrid[1][0]);
            Mbb.Text = System.Convert.ToString(solvedSudokuGrid[1][1]);
            Mbc.Text = System.Convert.ToString(solvedSudokuGrid[1][2]);
            Mbd.Text = System.Convert.ToString(solvedSudokuGrid[1][3]);
            Mbe.Text = System.Convert.ToString(solvedSudokuGrid[1][4]);
            Mbf.Text = System.Convert.ToString(solvedSudokuGrid[1][5]);
            Mbg.Text = System.Convert.ToString(solvedSudokuGrid[1][6]);
            Mbh.Text = System.Convert.ToString(solvedSudokuGrid[1][7]);
            Mbi.Text = System.Convert.ToString(solvedSudokuGrid[1][8]);

            Mca.Text = System.Convert.ToString(solvedSudokuGrid[2][0]);
            Mcb.Text = System.Convert.ToString(solvedSudokuGrid[2][1]);
            Mcc.Text = System.Convert.ToString(solvedSudokuGrid[2][2]);
            Mcd.Text = System.Convert.ToString(solvedSudokuGrid[2][3]);
            Mce.Text = System.Convert.ToString(solvedSudokuGrid[2][4]);
            Mcf.Text = System.Convert.ToString(solvedSudokuGrid[2][5]);
            Mcg.Text = System.Convert.ToString(solvedSudokuGrid[2][6]);
            Mch.Text = System.Convert.ToString(solvedSudokuGrid[2][7]);
            Mci.Text = System.Convert.ToString(solvedSudokuGrid[2][8]);

            Mda.Text = System.Convert.ToString(solvedSudokuGrid[3][0]);
            Mdb.Text = System.Convert.ToString(solvedSudokuGrid[3][1]);
            Mdc.Text = System.Convert.ToString(solvedSudokuGrid[3][2]);
            Mdd.Text = System.Convert.ToString(solvedSudokuGrid[3][3]);
            Mde.Text = System.Convert.ToString(solvedSudokuGrid[3][4]);
            Mdf.Text = System.Convert.ToString(solvedSudokuGrid[3][5]);
            Mdg.Text = System.Convert.ToString(solvedSudokuGrid[3][6]);
            Mdh.Text = System.Convert.ToString(solvedSudokuGrid[3][7]);
            Mdi.Text = System.Convert.ToString(solvedSudokuGrid[3][8]);

            Mea.Text = System.Convert.ToString(solvedSudokuGrid[4][0]);
            Meb.Text = System.Convert.ToString(solvedSudokuGrid[4][1]);
            Mec.Text = System.Convert.ToString(solvedSudokuGrid[4][2]);
            Med.Text = System.Convert.ToString(solvedSudokuGrid[4][3]);
            Mee.Text = System.Convert.ToString(solvedSudokuGrid[4][4]);
            Mef.Text = System.Convert.ToString(solvedSudokuGrid[4][5]);
            Meg.Text = System.Convert.ToString(solvedSudokuGrid[4][6]);
            Meh.Text = System.Convert.ToString(solvedSudokuGrid[4][7]);
            Mei.Text = System.Convert.ToString(solvedSudokuGrid[4][8]);

            Mfa.Text = System.Convert.ToString(solvedSudokuGrid[5][0]);
            Mfb.Text = System.Convert.ToString(solvedSudokuGrid[5][1]);
            Mfc.Text = System.Convert.ToString(solvedSudokuGrid[5][2]);
            Mfd.Text = System.Convert.ToString(solvedSudokuGrid[5][3]);
            Mfe.Text = System.Convert.ToString(solvedSudokuGrid[5][4]);
            Mff.Text = System.Convert.ToString(solvedSudokuGrid[5][5]);
            Mfg.Text = System.Convert.ToString(solvedSudokuGrid[5][6]);
            Mfh.Text = System.Convert.ToString(solvedSudokuGrid[5][7]);
            Mfi.Text = System.Convert.ToString(solvedSudokuGrid[5][8]);

            Mga.Text = System.Convert.ToString(solvedSudokuGrid[7][0]);
            Mgb.Text = System.Convert.ToString(solvedSudokuGrid[7][1]);
            Mgc.Text = System.Convert.ToString(solvedSudokuGrid[7][2]);
            Mgd.Text = System.Convert.ToString(solvedSudokuGrid[7][3]);
            Mge.Text = System.Convert.ToString(solvedSudokuGrid[7][4]);
            Mgf.Text = System.Convert.ToString(solvedSudokuGrid[7][5]);
            Mgg.Text = System.Convert.ToString(solvedSudokuGrid[7][6]);
            Mgh.Text = System.Convert.ToString(solvedSudokuGrid[7][7]);
            Mgi.Text = System.Convert.ToString(solvedSudokuGrid[7][8]);

            Mha.Text = System.Convert.ToString(solvedSudokuGrid[6][0]);
            Mhb.Text = System.Convert.ToString(solvedSudokuGrid[6][1]);
            Mhc.Text = System.Convert.ToString(solvedSudokuGrid[6][2]);
            Mhd.Text = System.Convert.ToString(solvedSudokuGrid[6][3]);
            Mhe.Text = System.Convert.ToString(solvedSudokuGrid[6][4]);
            Mhf.Text = System.Convert.ToString(solvedSudokuGrid[6][5]);
            Mhg.Text = System.Convert.ToString(solvedSudokuGrid[6][6]);
            Mhh.Text = System.Convert.ToString(solvedSudokuGrid[6][7]);
            Mhi.Text = System.Convert.ToString(solvedSudokuGrid[6][8]);

            Mia.Text = System.Convert.ToString(solvedSudokuGrid[8][0]);
            Mib.Text = System.Convert.ToString(solvedSudokuGrid[8][1]);
            Mic.Text = System.Convert.ToString(solvedSudokuGrid[8][2]);
            Mid.Text = System.Convert.ToString(solvedSudokuGrid[8][3]);
            Mie.Text = System.Convert.ToString(solvedSudokuGrid[8][4]);
            Miif.Text = System.Convert.ToString(solvedSudokuGrid[8][5]);
            Mig.Text = System.Convert.ToString(solvedSudokuGrid[8][6]);
            Mih.Text = System.Convert.ToString(solvedSudokuGrid[8][7]);
            Mii.Text = System.Convert.ToString(solvedSudokuGrid[8][8]);

        }
        int[][] Grid_toInt(){

            int aa;
            if(Maa.Text == null){
                aa = 0;
            }
            else {
                aa = System.Convert.ToInt32(Maa.Text);
            }

            int ab = System.Convert.ToInt32(Mab.Text);
            int ac = System.Convert.ToInt32(Mac.Text);
            int ad = System.Convert.ToInt32(Mad.Text);
            int ae = System.Convert.ToInt32(Mae.Text);
            int af = System.Convert.ToInt32(Maf.Text);
            int ag = System.Convert.ToInt32(Mag.Text);
            int ah = System.Convert.ToInt32(Mah.Text);
            int ai = System.Convert.ToInt32(Mai.Text);

            int ba = System.Convert.ToInt32(Mba.Text);
            int bb = System.Convert.ToInt32(Mbb.Text);
            int bc = System.Convert.ToInt32(Mbc.Text);
            int bd = System.Convert.ToInt32(Mbd.Text);
            int be = System.Convert.ToInt32(Mbe.Text);
            int bf = System.Convert.ToInt32(Mbf.Text);
            int bg = System.Convert.ToInt32(Mbg.Text);
            int bh = System.Convert.ToInt32(Mbh.Text);
            int bi = System.Convert.ToInt32(Mbi.Text);

            int ca = System.Convert.ToInt32(Mca.Text);
            int cb = System.Convert.ToInt32(Mcb.Text);
            int cc = System.Convert.ToInt32(Mcc.Text);
            int cd = System.Convert.ToInt32(Mcd.Text);
            int ce = System.Convert.ToInt32(Mce.Text);
            int cf = System.Convert.ToInt32(Mcf.Text);
            int cg = System.Convert.ToInt32(Mcg.Text);
            int ch = System.Convert.ToInt32(Mch.Text);
            int ci = System.Convert.ToInt32(Mci.Text);

            int da = System.Convert.ToInt32(Mda.Text);
            int db = System.Convert.ToInt32(Mdb.Text);
            int dc = System.Convert.ToInt32(Mdc.Text);
            int dd = System.Convert.ToInt32(Mdd.Text);
            int de = System.Convert.ToInt32(Mde.Text);
            int df = System.Convert.ToInt32(Mdf.Text);
            int dg = System.Convert.ToInt32(Mdg.Text);
            int dh = System.Convert.ToInt32(Mdh.Text);
            int di = System.Convert.ToInt32(Mdi.Text);

            int ea = System.Convert.ToInt32(Mea.Text);
            int eb = System.Convert.ToInt32(Meb.Text);
            int ec = System.Convert.ToInt32(Mec.Text);
            int ed = System.Convert.ToInt32(Med.Text);
            int ee = System.Convert.ToInt32(Mee.Text);
            int ef = System.Convert.ToInt32(Mef.Text);
            int eg = System.Convert.ToInt32(Meg.Text);
            int eh = System.Convert.ToInt32(Meh.Text);
            int ei = System.Convert.ToInt32(Mei.Text);

            int fa = System.Convert.ToInt32(Mfa.Text);
            int fb = System.Convert.ToInt32(Mfb.Text);
            int fc = System.Convert.ToInt32(Mfc.Text);
            int fd = System.Convert.ToInt32(Mfd.Text);
            int fe = System.Convert.ToInt32(Mfe.Text);
            int ff = System.Convert.ToInt32(Mff.Text);
            int fg = System.Convert.ToInt32(Mfg.Text);
            int fh = System.Convert.ToInt32(Mfh.Text);
            int fi = System.Convert.ToInt32(Mfi.Text);

            int ga = System.Convert.ToInt32(Mga.Text);
            int gb = System.Convert.ToInt32(Mgb.Text);
            int gc = System.Convert.ToInt32(Mgc.Text);
            int gd = System.Convert.ToInt32(Mgd.Text);
            int ge = System.Convert.ToInt32(Mge.Text);
            int gf = System.Convert.ToInt32(Mgf.Text);
            int gg = System.Convert.ToInt32(Mgg.Text);
            int gh = System.Convert.ToInt32(Mgh.Text);
            int gi = System.Convert.ToInt32(Mgi.Text);

            int ha = System.Convert.ToInt32(Mha.Text);
            int hb = System.Convert.ToInt32(Mhb.Text);
            int hc = System.Convert.ToInt32(Mhc.Text);
            int hd = System.Convert.ToInt32(Mhd.Text);
            int he = System.Convert.ToInt32(Mhe.Text);
            int hf = System.Convert.ToInt32(Mhf.Text);
            int hg = System.Convert.ToInt32(Mhg.Text);
            int hh = System.Convert.ToInt32(Mhh.Text);
            int hi = System.Convert.ToInt32(Mhi.Text);

            int ia = System.Convert.ToInt32(Mia.Text);
            int ib = System.Convert.ToInt32(Mib.Text);
            int ic = System.Convert.ToInt32(Mic.Text);
            int id = System.Convert.ToInt32(Mid.Text);
            int ie = System.Convert.ToInt32(Mie.Text);
            int iif = System.Convert.ToInt32(Miif.Text);
            int ig = System.Convert.ToInt32(Mig.Text);
            int ih = System.Convert.ToInt32(Mih.Text);
            int ii = System.Convert.ToInt32(Mii.Text);


            Int32[][] sudokuPuzzle = new int[][] {
                new int[]{aa,ab,ac,ad,ae,af,ag,ah,ai},
                new int[]{ba,bb,bc,bd,be,bf,bg,bh,bi},
                new int[]{ca,cb,cc,cd,ce,cf,cg,ch,ci},
                new int[]{da,db,dc,dd,de,df,dg,dh,di},
                new int[]{ea,eb,ec,ed,ee,ef,eg,eh,ei},
                new int[]{fa,fb,fc,fd,fe,ff,fg,fh,fi},
                new int[]{ga,gb,gc,gd,ge,gf,gg,gh,gi},
                new int[]{ha,hb,hc,hd,he,hf,hg,hh,hi},
                new int[]{ia,ib,ic,id,ie,iif,ig,ih,ii}};

            return sudokuPuzzle;
        }


    }
}
