using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace UnityGameFramework {
    public static class UGFEvent {
        private static EventComponent component;

        public static EventComponent Component
        {
            get
            {
                return component;
            }

            set
            {
                component = value;
            }
        }
    }
	
}

