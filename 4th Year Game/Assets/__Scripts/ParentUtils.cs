using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utilities
{
    public class ParentUtils
    {
        //public const string BULLET_PARENT = "BulletParent";
        public const string BLOCK_PARENT = "BlockParent";

        //public static GameObject GetBulletParent()
        //{
        //    return GetParent(BULLET_PARENT);
        //}

        public static GameObject GetBlockParent()
        {
            return GetParent(BLOCK_PARENT);
        }

        private static GameObject GetParent(string parentName)
        {
            var parent = GameObject.Find(parentName);
            if(!parent)
            {
                parent = new GameObject(parentName);
            }
            return parent;
        }


    }
}
