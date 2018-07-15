using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace UnityGameFramework {
    public static class UGF {
        private static EventComponent eventComponent;

        public static EventComponent EventComponent
        {
            get
            {
                return eventComponent;
            }

            set
            {
                eventComponent = value;
            }
        }
    }
	
}

