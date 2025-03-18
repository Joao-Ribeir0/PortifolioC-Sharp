using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace AgendaContatos
{
    public class Contato
    {
        private string _email;
        private string _telefone;
        public string Nome { get; set; }
        public string Telefone
        {
            get => _telefone;
            set
            {
                if (IsTelefoneValido(value))
                {
                    _telefone = value;
                }
                else
                {
                    throw new ArgumentException("Telefone incorreto. Digite um email no formato '(XX)9XXXX-XXXX'");
                }

            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (IsEmailValido(value))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Email inválido. Digite um email no formato 'exemplo@hotmail.com'");
                }
            }
        }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        private bool IsEmailValido(string email)
        {
            var regex = new Regex(@"^[\w]+@([\w]+\.)+[\w]{2,4}$");
            return regex.IsMatch(email);
        }

        private bool IsTelefoneValido(string telefone)
        {
            var regex = new Regex(@"^\((\d{2})\)9(\d{4})\-(\d{4})$");
            return regex.IsMatch(telefone);
        }
    }
}
