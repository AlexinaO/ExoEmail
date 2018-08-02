using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExoEmail
{
    public class Email
    {
        public string Sujet { get; set; }
        public string Destinataire { get; set; }
        public string[] DestinatairesEnCopie { get; set; }
        public string Contenu { get; set; }

        public List<PieceJointe> PiecesJointes { get; set; }
        public PieceJointe PieceJointe { get; set; } //si de 0 à 1 seule pièce jointe par email
    }
    public class PieceJointe
    {
        public Email Email { get; set; }
        public DateTime DateAjout { get; set; }
        public FileInfo Fichier { get; set; }
    }


}
