using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShell.Chipter3
{
    internal class Note
    {
        public int Pitch { get; init; } = 20; // “Init-only” property
        public int Duration { get; init; } = 100; // “Init-only” property

        // These init-only properties act like read-only properties, except that they can
        // also be set via an object initializer:

        // Init-only properties cannot even be set from inside their class, except via their property initializer, the constructor, or another init-only accessor.

        public int Pitch1 { get; }
        public int Duration1 { get; }
        public Note(int pitch = 20, int duration = 100)
        {
            Pitch1 = pitch; Duration1 = duration;
        }

        //Init-only properties have another significant advantage, which is that they allow for nondestructive mutation when used in conjunction with records

        readonly int _pitch;
        public int Pitch2 { get => _pitch; init => _pitch = value; }

    }
}
