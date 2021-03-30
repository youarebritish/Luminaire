using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Newtonsoft.Json;

namespace SQEX.Luminous.Core.Object
{

    public class LuminousSceneManager : MonoBehaviour
    {

        public void TestDbjectType()
        {
            LuminousObject[] components = Resources.FindObjectsOfTypeAll<LuminousObject>();

            foreach(LuminousObject comp in components)
            {
                ObjectType objectType = comp.Entity.GetObjectType(); 
                PropertyContainer propertyContainer = objectType.PropertyContainer;

                foreach (Property prop in propertyContainer.AllProperties)
                {
                    var propName = prop.Name; //element name
                    var propType = prop.Type; //has attribute value eg type="Bool" but always has first capital letter, can get mixed up with Fixid

                    var propValue = comp.Entity.GetPropertyValue<System.Object>(prop); ///element value
                }
            }
        }
    }
}