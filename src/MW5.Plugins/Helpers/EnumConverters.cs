﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Enums;
using MW5.Plugins.Enums;
using MW5.Shared;

namespace MW5.Plugins.Helpers
{
    public class GdalDriverMetadataConverter : IEnumConverter<GdalDriverMetadata>
    {
        public string GetString(GdalDriverMetadata value)
        {
            switch (value)
            {
                case GdalDriverMetadata.Longname:
                    return "Long name";
                case GdalDriverMetadata.HelpTopic:
                    return "Help topic";
                case GdalDriverMetadata.MimeType:
                    return "Mime type";
                case GdalDriverMetadata.Extension:
                    return "Extension";
                case GdalDriverMetadata.Extensions:
                    return "Extensions";
                case GdalDriverMetadata.CreationOptionList:
                    return "Creation option list";
                case GdalDriverMetadata.OpenOptionList:
                    return "Open option list";
                case GdalDriverMetadata.CreationDataTypes:
                    return "Creation data types";
                case GdalDriverMetadata.SubDatasets:
                    return "Sub datasets";
                case GdalDriverMetadata.Open:
                    return "Supports open";
                case GdalDriverMetadata.Create:
                    return "Supports creation";
                case GdalDriverMetadata.CreateCopy:
                    return "Supports create copy";
                case GdalDriverMetadata.VirtualIo:
                    return "Supports virtual IO";
                case GdalDriverMetadata.LayerCreationOptionList:
                    return "Layer creation option list";
                case GdalDriverMetadata.OgrDriver:
                    return "Is OGR driver";
                case GdalDriverMetadata.Raster:
                    return "Is raster";
                case GdalDriverMetadata.Vector:
                    return "Is vector";
                case GdalDriverMetadata.NotNullFields:
                    return "Not null fields";
                case GdalDriverMetadata.DefaultFields:
                    return "Default fields";
                case GdalDriverMetadata.NotNullGeometries:
                    return "Not null geometries";
                case GdalDriverMetadata.CreateFieldDataTypes:
                    return "Creation field data types";
            }

            return string.Empty;
        }
    }

    public class AutoToggleConverter : IEnumConverter<AutoToggle>
    {
        public string GetString(AutoToggle value)
        {
            switch (value)
            {
                case AutoToggle.Auto:
                    return "Auto";
                case AutoToggle.True:
                    return "Always";
                case AutoToggle.False:
                    return "Never";
            }

            return string.Empty;
        }
    }

    public class ResizeBehaviorConverter : IEnumConverter<ResizeBehavior>
    {
        public string GetString(ResizeBehavior value)
        {
            switch (value)
            {
                case ResizeBehavior.Classic:
                    return "Classic";
                case ResizeBehavior.Modern:
                    return "Modern";
                case ResizeBehavior.Intuitive:
                    return "Intuitive";
                case ResizeBehavior.Warp:
                    return "Warp";
                case ResizeBehavior.KeepScale:
                    return "Keep scale";
            }

            return string.Empty;
        }
    }

    public class ScalebarUnitsConverter : IEnumConverter<ScalebarUnits>
    {
        public string GetString(ScalebarUnits value)
        {
            switch (value)
            {
                case ScalebarUnits.Metric:
                    return "Metric";
                case ScalebarUnits.American:
                    return "American";
                case ScalebarUnits.GoogleStyle:
                    return "Google style";
            }

            return string.Empty;
        }
    }

    public class ZoomBehaviorConverter : IEnumConverter<ZoomBehavior>
    {
        public string GetString(ZoomBehavior value)
        {
            switch (value)
            {
                case ZoomBehavior.Default:
                    return "Default (no discrete levels)";
                case ZoomBehavior.UseTileLevels:
                    return "Snap to tile levels";
            }

            return string.Empty;
        }
    }

    public class MouseWheelDirectionConverter : IEnumConverter<MouseWheelDirection>
    {
        public string GetString(MouseWheelDirection value)
        {
            switch (value)
            {
                case MouseWheelDirection.Forward:
                    return "Forward";
                case MouseWheelDirection.Reverse:
                    return "Reverse";
                case MouseWheelDirection.None:
                    return "None";
            }

            return string.Empty;
        }
    }

    public class ZoombarVerbosityConverter : IEnumConverter<ZoomBarVerbosity>
    {
        public string GetString(ZoomBarVerbosity value)
        {
            switch (value)
            {
                case ZoomBarVerbosity.ZoomOnly:
                    return "Show zoom level only";
                case ZoomBarVerbosity.Full:
                    return "Show full info";
                case ZoomBarVerbosity.None:
                    return "Don't show any info";
            }

            return string.Empty;
        }
    }

    public class ZoomBoxStyleConverter : IEnumConverter<ZoomBoxStyle>
    {
        public string GetString(ZoomBoxStyle value)
        {
            switch (value)
            {
                case ZoomBoxStyle.RubberBand:
                    return "Rubber band";
                case ZoomBoxStyle.Gray:
                    return "Gray";
                case ZoomBoxStyle.GrayInverted:
                    return "Inverted gray";
                case ZoomBoxStyle.Orange:
                    return "Orange";
                case ZoomBoxStyle.Blue:
                    return "Blue";
            }

            return string.Empty;
        }
    }

    public class ProjectionMistmatchConverter : IEnumConverter<ProjectionMismatch>
    {
        public string GetString(Enums.ProjectionMismatch value)
        {
            switch (value)
            {
                case ProjectionMismatch.IgnoreMismatch:
                    return "Ignore mismatch";
                case ProjectionMismatch.Reproject:
                    return "Reproject";
                case ProjectionMismatch.SkipFile:
                    return "Skip file";
            }

            return string.Empty;
        }
    }

    public class ProjectionAbsenceConverter : IEnumConverter<ProjectionAbsence>
    {
        public string GetString(Enums.ProjectionAbsence value)
        {
            switch (value)
            {
                case ProjectionAbsence.AssignFromProject:
                    return "Assign from project";
                case ProjectionAbsence.IgnoreAbsence:
                    return "Ignore absence";
                case ProjectionAbsence.SkipFile:
                    return "SKip file";
            }

            return string.Empty;
        }
    }
}
