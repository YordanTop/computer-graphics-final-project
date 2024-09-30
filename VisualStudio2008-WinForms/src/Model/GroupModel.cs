using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class GroupModel:Shape
    {
        private List<Shape> group;

        public List<Shape> GroupList
        {
            get { return group; }
            set { group = value; }
        }

        public string GroupName { get; set; }

    }
}
