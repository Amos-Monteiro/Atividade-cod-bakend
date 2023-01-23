using System;
namespace Atividade
{
    class program
    {
        static void Main(string[]args)
        { 
           float val_pag;
           Console.WriteLine("Informar Nome");
           string var_nome = Console.ReadLine();
           Console.WriteLine("Informar Endereço");
           string var_endereco = Console.ReadLine();
           Console.WriteLine("Pessoa Física(f)ou Pessoa Jurídica (j)?");
           string var_tipo = Console.ReadLine();
           if (var_tipo == "f")
           {
            // -- Pessoa fisica --
            Pessoa_fisica pf = new Pessoa_fisica();
            pf.nome = var_nome;
            pf.endereco = var_endereco;
            Console.WriteLine("Informar CPF:");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("Informar RG:");
            pf.rg = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pf.Pagar_imposto(val_pag);
            Console.WriteLine("----- Pessoa Física -----");
            Console.WriteLine("Nome......: " + pf.nome);
            Console.WriteLine("Endereço.......: " + pf.endereco);
            Console.WriteLine("CPF.....: " + pf.cpf);
            Console.WriteLine("RG........: "+ pf.rg);
            Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
            Console.WriteLine("Imposto......: " + pf.valor_imposto.ToString("C"));
            Console.WriteLine("Total à Pagar: " + pf.total.ToString("C"));
           }
           if (var_tipo == "j")
           {
            // ---- pessoa Jurídica.
            Pessoa_Juridica PJ = new Pessoa_Juridica();
            PJ.nome = var_nome;
            PJ.endereco = var_endereco;
            Console.WriteLine("Informar CNPJ:");
            PJ.cnpj = Console.ReadLine();
            Console.WriteLine("Informar IE:");
            PJ.ie = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            PJ.Pagar_imposto(val_pag);
            Console.WriteLine("------ Pessoa Jurídica");
            Console.WriteLine("Nome...........: " + PJ.nome);
            Console.WriteLine("Endereço.......: " + PJ.endereco);
            Console.WriteLine("CNPJ...........: " + PJ.cnpj);
            Console.WriteLine("IE.............: " + PJ.ie);
            Console.WriteLine("Valor de compra: " + PJ.valor.ToString("C"));
            Console.WriteLine("Importo........: " + PJ.valor_imposto.ToString("C"));
            Console.WriteLine("Total à Pagar..: " + PJ.total.ToString("C"));
           }
           
           



        }
    }
}