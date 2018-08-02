using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoEmail
{
    public class Email
    {
        public string Sujet { get; set; } // Ceci est une propriété donc peut être publique cela revient à
        /* private string_sujet;
         * public string Sujet
         * {
         * get{return _sujet;}
         * set{_sujet=value;}
         * }*/
        public string Destinataire { get; set; }
        public string[] DestinatairesEnCopie { get; set; }
        public string Contenu { get; set; }

        public List<PieceJointe> PiecesJointes { get; set; }
        public PieceJointe PieceJointe { get; set; } //si de 0 à 1 seule pièce jointe par email
    }


}
