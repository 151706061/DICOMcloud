﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DICOMcloud.Dicom.DataAccess;
using fo = Dicom;


namespace DICOMcloud.Pacs.Commands
{
    public class StoreCommandData
    {
        public fo.DicomDataset Dataset { get; set; }
        public InstanceMetadata Metadata { get ; set; }
    }
}
