using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Instanzvariablen
{
    internal class Rectangle
    {
        // 2. Ein Feld, dessen Wert während der Lebensdauer eines Objekts nicht verändert werden kann. Instanziieren Sie anschliessend ein Objekt der betreffenden Klasse und überprüfen Sie den Wert mit dem Debugger.
        public readonly int coolness;
        // 3. 	3. Ein Feld, für welches ein Standardwert zugewiesen wird. Instanziieren Sie anschliessend ein Objekt der betreffenden Klasse, weisen Sie dem Feld einen anderen Wert zu und beobachten Sie die Veränderung im Debugger.
        public string name = "box";
        // .4 Eine selber implementierte, read-only Eigenschaft.
        public int height;
        public int Height { get { return height = 12; } }
        //5. Eine selber implementierte, read-write Eigenschaft.
        public int width;
        public int Width { get { return width; } set { width = value; } }
    }
}
