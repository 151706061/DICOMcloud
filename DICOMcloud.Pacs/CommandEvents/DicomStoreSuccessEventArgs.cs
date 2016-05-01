﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DICOMcloud.Core.Storage;

namespace DICOMcloud.Dicom.Data.Services
{
    public class DicomStoreSuccessEventArgs : EventArgs
    {
        public DicomStoreSuccessEventArgs ( Dictionary<string,IList<IStorageLocation>> mediaLocations, ObjectID objectId )
        {
            Locations = mediaLocations ;
            ObjectID  = objectId ;
        }

        public Dictionary<string,IList<IStorageLocation>> Locations { get; private set ; }
        public ObjectID ObjectID { get; set; }
    }
}
