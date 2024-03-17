using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbienteTransfGeometricas
{
    public partial class tela : Form
    {

        Bitmap areaDesenho;
        Color corPreenche;
        int x1, x2, y1, y2;
        bool inicio;
        float t1 = 0.0f;
        float t2 = 1.0f;
        public tela()
        {
            InitializeComponent();
            InicializarContexto();
        }

        private void InicializarContexto()
        {
            areaDesenho = new Bitmap(imagem.Size.Width, imagem.Size.Height);
            corPreenche = Color.Black;
            imagem.Image = areaDesenho;
            x1 = y1 = x2 = y2 = 0;
            txtX1.Text = txtY1.Text = txtX2.Text = txtY2.Text = "0";
            inicio = true;
        }

     

        private void btCor_Click(object sender, EventArgs e)
        {
            DialogResult result = cdlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                corPreenche = cdlg.Color;
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            areaDesenho = new Bitmap(imagem.Size.Width,
            imagem.Size.Height);
            imagem.Image = areaDesenho;
        }

        private void imagem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                txtX1.Text = Convert.ToString(x);
                txtY1.Text = Convert.ToString(y);
                areaDesenho.SetPixel(x, y, corPreenche);
                imagem.Image = areaDesenho;
            }
        }

        private void imagem_MouseClick(object sender, MouseEventArgs e)
        {
            if (inicio)
            {
                x1 = e.X;
                y1 = e.Y;
                txtX1.Text = x1.ToString();
                txtY1.Text = y1.ToString();
                areaDesenho.SetPixel(x1, y1, Color.Red);
                imagem.Image = areaDesenho;
                inicio = false;
            }
            else
            {
                x2 = e.X;
                y2 = e.Y;
                txtX2.Text = x2.ToString();
                txtY2.Text = y2.ToString();
                areaDesenho.SetPixel(x2, y2, Color.Red);
                imagem.Image = areaDesenho;
                inicio = true;
            }
        }

        private void imagem_MouseRight(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int x = e.X;
                int y = e.Y;
                txtX1.Text = Convert.ToString(x);
                txtY1.Text = Convert.ToString(y);
                areaDesenho.SetPixel(x, y, corPreenche);
                imagem.Image = areaDesenho;
            }
        }



        private void drawLineAtiv1(object sender, EventArgs e)
        {

            DDA(x1, y1, x2, y2);

        }

        private void DDA(int x1, int y1, int x2, int y2)
        {
            try
            {
                int deltaX, deltaY, passos, moduloDeltaX, moduloDeltaY; 
                double x, y, xincrease, yincrease;

                //Pega os pontos iniciais (serviria qualquer um dos pares)
                x = x1;
                y = y1;

                //seta primeiro pixel
                areaDesenho.SetPixel((int)x, (int)y, corPreenche);
                imagem.Image = areaDesenho;

                // Cacula a diferenca entre os pontos (delta)
                deltaX = x2 - x1;
                deltaY = y2 - y1;

                //Ajuste para achar o módulo do delta
                if (deltaX < 0)
                    moduloDeltaX = deltaX * (-1);
                else
                    moduloDeltaX = deltaX;

                if (deltaY < 0)
                    moduloDeltaY = deltaY * (-1);
                else
                    moduloDeltaY = deltaY;

                //Pega a maior diferenca entre os Xs ou Ys e define como número de passos garantindo que serão preenchidos
                //todos os pontos entre os dois pontos
                if (moduloDeltaX > moduloDeltaY) 
                    passos = moduloDeltaX;
                else 
                    passos = moduloDeltaY;

                //Calculo os incrementos para realizar os avanços pelos eixos (Esses valores serão utilizados como constantes de aumento) 
                xincrease = calcularValorIncremento((double)deltaX , passos);
                yincrease = calcularValorIncremento((double)deltaY , passos);

                //realiza os incrementos posteriores repetitivamente
                for (int i = 1; i <= passos; i++)
                {
                    //Aumenta os valores do novo ponto baseado no valor de incremento calculado anterirormente
                    x += xincrease;
                    y += yincrease;
                    //Cria o ponto na tela
                    areaDesenho.SetPixel((int)x, (int)y, corPreenche);
                    imagem.Image = areaDesenho;
                }

            }
            catch (Exception ex)
            {
                //O plot continua a ocorrer mesmo violando o tamanho do canva
                Console.WriteLine("Saindo da tela, Erro:" + ex);
            }
        }

        private void translacao(object sender, EventArgs e)
        {
            this.btApagar_Click(sender, e);

            int xTransladado1 = x1 = x1 + 2;
            int yTransladado1 = y1 = y1 + 2;
            int xTransladado2 = x2 = x2 + 3;
            int yTransladado2 = y2 = y2 + 3;

            DDA(xTransladado1, yTransladado1, xTransladado2, yTransladado2);

        }
        private void escala(object sender, EventArgs e)
        {
            this.btApagar_Click(sender, e);

            var fatorEscala = 1.3;

            int xEscala1 = x1 = (int)(x1 * fatorEscala);
            int yEscala1 = y1 = (int)(y1 * fatorEscala);
            int xEscala2 = x2 = (int)(x2 * fatorEscala);
            int yEscala2 = y2 = (int)(y2 * fatorEscala);

            DDA(xEscala1, yEscala1, xEscala2, yEscala2);
        }

        private void escalaDown(object sender, EventArgs e)
        {
            this.btApagar_Click(sender, e);

            var fatorEscala = 1.3;

            int xEscala1 = x1 = (int)(x1 / fatorEscala);
            int yEscala1 = y1 = (int)(y1 / fatorEscala);
            int xEscala2 = x2 = (int)(x2 / fatorEscala);
            int yEscala2 = y2 = (int)(y2 / fatorEscala);

            DDA(xEscala1, yEscala1, xEscala2, yEscala2);
        }


        private void rotacao(object sender, EventArgs e)
        {
            this.btApagar_Click(sender, e);

            // Converte o ângulo para radianos (As funções do Math utilizam dessa forma)
            double ParaRadianos = 15 * (Math.PI / 180.0);

            //Pega um ponto Central para X e Y para fazer a rotação
            int PontoMedioX = (x1 + x2) / 2;
            int PontoMedioY = (y1 + y2) / 2;

            // rotaciona cada cordenada de acordo com o centro da rotação (PontoMedio X/Y)
            int xRotacionado1 = x1 = (int)((x1 - PontoMedioX) * Math.Cos(ParaRadianos) - (y1 - PontoMedioY) * Math.Sin(ParaRadianos) + PontoMedioX);
            int yRotacionado1 = y1 = (int)((x1 - PontoMedioX) * Math.Sin(ParaRadianos) + (y1 - PontoMedioY) * Math.Cos(ParaRadianos) + PontoMedioY);
            int xRotacionado2 = x2 =(int)((x2 - PontoMedioX) * Math.Cos(ParaRadianos) - (y2 - PontoMedioY) * Math.Sin(ParaRadianos) + PontoMedioX);
            int yRotacionado2 = y2 = (int)((x2 - PontoMedioX) * Math.Sin(ParaRadianos) + (y2 - PontoMedioY) * Math.Cos(ParaRadianos) + PontoMedioY);

            // Desenha a linha baseada nos novos pontos
            DDA(xRotacionado1, yRotacionado1, xRotacionado2, yRotacionado2);

        }

        private void btBress_Click(object Sender, EventArgs e)
        {
            bresenham(x1, y1, x2, y2);
        }

        private void bresenham(int x1, int y1, int x2, int y2)
        {
            int deltaX = x2 - x1;
            int deltaY = y2 - y1;
            int x = x1, y = y1, xincremento, yincremento, c1, c2, p;

            if (deltaX > 0)
                xincremento = 1;
            else
            {
                xincremento = -1; 
                deltaX = -deltaX;
            }


            if (deltaY > 0)
                yincremento = 1;
            else
            {
                yincremento = -1;
                deltaY = -deltaY;
            }

            areaDesenho.SetPixel(x, y, corPreenche);
            imagem.Image = areaDesenho;

            if(deltaX > deltaY) // 1 caso
            {
                p = 2 * deltaY - deltaX;
                c1 = 2 * deltaY;
                c2 = 2 * (deltaY - deltaX);

                for(int i = 0;i < deltaX ; i++ )
                {
                    x += xincremento;
                    if (p < 0) 
                     p += c1;
                    else
                    {
                        p += c2;
                        y += yincremento;
                    }
                    areaDesenho.SetPixel(x, y, corPreenche);
                    imagem.Image = areaDesenho;
                }//fim for
            }
            else
            {
                p = 2 * deltaX - deltaY;
                c1 = 2 * deltaX;
                c2 = 2 * (deltaX - deltaY);
                for(int i = 0; i <deltaY; i++)
                {
                    y += yincremento;
                    if (p < 0) 
                     p += c1;
                    else
                    {
                        p += c2;
                        x += xincremento;
                    }
                    areaDesenho.SetPixel(x, y, corPreenche);
                    imagem.Image = areaDesenho;
                }
            }


        }//fim funcao

        private void btCirculo_Click(object Sender, EventArgs e)
        {
            int raio = (int)Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            FazerCirculo(x1, y1, raio);
        }

        private void FazerCirculo( int xc, int yc, int r)
        {

            void DrawCircle(int xt, int yt)
            {
                try
                {
                    areaDesenho.SetPixel(xc + xt, yc + yt, corPreenche);
                    areaDesenho.SetPixel(xc - xt, yc + yt, corPreenche);
                    areaDesenho.SetPixel(xc + xt, yc - yt, corPreenche);
                    areaDesenho.SetPixel(xc - xt, yc - yt, corPreenche);
                    areaDesenho.SetPixel(xc + yt, yc + xt, corPreenche);
                    areaDesenho.SetPixel(xc - yt, yc + xt, corPreenche);
                    areaDesenho.SetPixel(xc + yt, yc - xt, corPreenche);
                    areaDesenho.SetPixel(xc - yt, yc - xt, corPreenche);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            int xo = 0, yo = r;
            int d = 3 - 2 * r;
            DrawCircle(xo, yo);

            while (yo >= xo)
            {
                xo++;

                if (d > 0)
                {
                    yo--;
                    d += 4 * (xo - yo) + 10;
                }
                else
                {
                    d += 4 * xo + 6;
                }
                DrawCircle(xo, yo);
            }
            imagem.Image = areaDesenho;
        }

        private void btCohen_Click(object sender, EventArgs e)
        {
            int xmin = Math.Min(Int32.Parse(txtXmin.Text), Int32.Parse(txtXmax.Text)),
            ymin = Math.Min(Int32.Parse(txtYmin.Text), Int32.Parse(txtYmax.Text)),
            xmax = Math.Max(Int32.Parse(txtXmin.Text), Int32.Parse(txtXmax.Text)),
            ymax = Math.Max(Int32.Parse(txtYmin.Text), Int32.Parse(txtYmax.Text));

            txtXmin.Text = xmin.ToString();
            txtYmin.Text = ymin.ToString();
            txtXmax.Text = xmax.ToString();
            txtYmax.Text = ymax.ToString();

            Cohen(x1, y1, x2, y2, xmin, ymin, xmax, ymax);
        }

        private void Liang_Click(object sender, EventArgs e)
        {
            int xmin = Math.Min(Int32.Parse(txtXmin.Text), Int32.Parse(txtXmax.Text)),
            ymin = Math.Min(Int32.Parse(txtYmin.Text), Int32.Parse(txtYmax.Text)),
            xmax = Math.Max(Int32.Parse(txtXmin.Text), Int32.Parse(txtXmax.Text)),
            ymax = Math.Max(Int32.Parse(txtYmin.Text), Int32.Parse(txtYmax.Text));

            txtXmin.Text = xmin.ToString();
            txtYmin.Text = ymin.ToString();
            txtXmax.Text = xmax.ToString();
            txtYmax.Text = ymax.ToString();

            Liang(x1, y1, x2, y2, xmin, ymin, xmax, ymax);
        }


        bool clipTest(float p, float q)
        {
            float r;
            if (p < 0.0)
            {
                r = q / p;
                if (r > t2)
                    return false;
                else if (r > t1)
                    t1 = r;
            }
            else if (p > 0.0)
            {
                r = q / p;
                if (r < t1)
                    return false;
                else if (r < t2)
                    t2 = r;
            }
            else if (q < 0.0)
                return false;

            return true;
        }
        private void Liang(int xi, int yi, int xf, int yf, int xmin, int ymin, int xmax, int ymax)
        {
            Apagar();
            DesenhaJanela(xmin, ymin, xmax, ymax);
            float X1, X2, Y1, Y2;
            X1 = (float)xi;
            Y1 = (float)yi;
            X2 = (float)xf;
            Y2 = (float)yf;
            float dx = X2 - X1;
            float dy = Y2 - Y1;
            

            if (clipTest(-dx, X1 - (float)xmin))
                if (clipTest(dx, (float)xmax - X1))
                    if (clipTest(-dy, Y1 - (float)ymin))
                        if (clipTest(dy, (float)ymax - Y1))
                        {
                            if (t2 < 1.0)
                            {
                                X2 = X1 + t2 * dx;
                                Y2 = Y1 + t2 * dy;
                            }
                            if (t1 > 0.0)
                            {
                                X1 += t1 * dx;
                                Y1 += t1 * dy;
                            }
                            DDA((int)X1, (int)Y1, (int)X2, (int)Y2);
                        }
        }

            private void Cohen(int xi, int yi, int xf, int yf, int xmin, int ymin, int xmax, int ymax)
        {
            bool aceite = false, feito = false;
            int ci, cf, cfora, xint = 0, yint = 0;

            while (!feito)
            {
                ci = ObtemCodigo(xi, yi, xmin, ymin, xmax, ymax);
                cf = ObtemCodigo(xf, yf, xmin, ymin, xmax, ymax);
                if (ci == 0 && cf == 0) // dentro
                { aceite = true; feito = true; }
                else if ((ci & cf) != 0) // fora
                { feito = true; }
                else // tem cálculo para fazer
                {
                    if (ci != 0) cfora = ci;
                    else cfora = cf;

                    if ((cfora & 0b1) != 0) // esq
                    {
                        xint = xmin;
                        yint = yi + (yf - yi) * (xint - xi) / (xf - xi);
                    }
                    else if ((cfora & 0b10) != 0) // dir
                    {
                        xint = xmax;
                        yint = yi + (yf - yi) * (xint - xi) / (xf - xi);
                    }
                    else if ((cfora & 0b100) != 0) // inf
                    {
                        yint = ymin;
                        xint = xi + (xf - xi) * (yint - yi) / (yf - yi);
                    }
                    else if ((cfora & 0b1000) != 0) // sup
                    {
                        yint = ymax;
                        xint = xi + (xf - xi) * (yint - yi) / (yf - yi);
                    }

                    if (cfora == ci)
                    { xi = xint; yi = yint; }
                    else { xf = xint; yf = yint; }
                } // fim else dos cálculos
            } // fim while

            if (aceite)
            {
                Apagar();
                DDA(xi, yi, xf, yf);
                DesenhaJanela(xmin, ymin, xmax, ymax);
            }
        }

        private void Apagar()
        {
            areaDesenho = new Bitmap(imagem.Size.Width, imagem.Size.Height);
            imagem.Image = areaDesenho;
            InicializarContexto();
        }

        private int ObtemCodigo(int x, int y, int xmin, int ymin, int xmax, int ymax)
        {
            int cod = 0;

            if (x < xmin) cod++;
            if (x > xmax) cod += 2;
            if (y < ymin) cod += 4;
            if (y > ymax) cod += 8;

            return cod;
        }

        private void txtY1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesenhaJanela(int xmin, int ymin, int xmax, int ymax)
        {
            Graphics g = Graphics.FromImage(imagem.Image);
            Pen corJanela = new Pen(cdlg.Color);
            corJanela.DashStyle = DashStyle.DashDot;
            g.DrawLine(corJanela, xmin, ymin, xmax, ymin);
            g.DrawLine(corJanela, xmin, ymax, xmax, ymax);
            g.DrawLine(corJanela, xmin, ymin, xmin, ymax);
            g.DrawLine(corJanela, xmax, ymin, xmax, ymax);
        }

        private void reflexao(object sender, EventArgs e)
        {
            //Reflete horizontalmente (Esta jogando para fora da tela)
            this.btApagar_Click(sender, e);
            int xRefletido1 = x1 = -x1;
            int xRefletido2 = x2 = -x2;

            DDA(xRefletido1, y1, xRefletido2, y2);
        }
        
        //Metodos auxiliares
        
        //Calcula e retorna o valor de incremento para o DDA
        private double calcularValorIncremento(double delta, int passos)
        {
           var retorno =  (double)delta / passos;
            return retorno;
        }



    }
}
