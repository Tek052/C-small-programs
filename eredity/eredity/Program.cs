using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eredity
{
    public class Impiegato
    {
        private String nome;
        private double salario;
        private String matricola;
        private int anniDiServizio;
        public Impiegato(String n, double s, String m, int ads)
        {
            nome = n;
            salario = s;
            matricola = m;
            anniDiServizio = ads;
        }
        public void incrementaSalario(double percentuale)
        {
            salario *= 1 + percentuale / 100;
        }
        public void stampaInfo()
        {
            System.Console.WriteLine(nome + " " + salario + " " + matricola);
        }
        public String Nome
        {
            get { return nome; }
        }
        public int AnniServizio
        {
            get { return anniDiServizio; }
        }
    }

    class Manager : Impiegato
    {
        private String nomeSegretaria;
        public Manager(String n, double s, String m, int ads) : base(n, s, m, ads)
        {
            nomeSegretaria = String.Empty;
        }
        public void incrementaSalario(double percentuale)
        {
            // Aggiunge alla percentuale lo 0.5% per ogni anno di servizio
            double bonus = 0.5 * AnniServizio;
            base.incrementaSalario(percentuale + bonus);
        }
        public String Segretaria()
        {
            get { return nomeSegretaria; }
            set { nomeSegretaria = value; }
        }
    }