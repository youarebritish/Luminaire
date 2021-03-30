using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Newtonsoft.Json;

namespace SQEX.Luminous.Core.Object
{

    public class LuminousSceneManager : MonoBehaviour
    {

        //public class LuminousSceneManagerObject : Object
        //{
        //    [SerializeReference]
        //    public LuminousSceneManagerObject Entity;
        //    public void TestDebug()
        //    {
        //        UnityEngine.Debug.Log(Entity.GetFieldProperties());

        //        // here's where I start getting the LuminousObject properties and get it into XDoc
        //        // 

        //    }
        //}

        //public LuminousSceneManagerObject ManagerObject;
        public void TestDbjectType()
        {
            //UnityEngine.Debug.Log(ManagerObject.Entity.GetFieldProperties());

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