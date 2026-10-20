using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace FirstOOP

{

    public class Kuh
    {

        string _name; // private field for the name of the Kuhstring _colour; // private field for the colour of the Kuhpublic string Name // public property for the name of the Kuh        {

        get { return _name; } // getter for the nameset { _name = value; } // setter for the name        }


        public string Colour // public property for the colour of the Kuh        {

            get { return _colour; } // getter for the colourset { _colour = value; } // setter for the colour        }


// Constructor for the Kuh classpublic Kuh(string name, string colour)

{

    _name = name;

    _colour = colour;

}

    }

}