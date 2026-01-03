using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> d533be69f1fbccc5a00250b4152ec221b80709a0
    public class RefreshToken
    {
        public int RefreshTokenId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; } = null!;
        public string JwtId { get; set; } = null!;
        public DateTime ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? RevokedAt { get; set; }
        public bool IsRevoked { get; set; }
        public bool IsUsed { get; set; }
<<<<<<< HEAD
    } 

=======
=======
    internal class RefreshToken
    {
>>>>>>> fbccb78aa3ea25cdd5cd36b2a63c353ebb74cb7f
    }
>>>>>>> d533be69f1fbccc5a00250b4152ec221b80709a0
}
