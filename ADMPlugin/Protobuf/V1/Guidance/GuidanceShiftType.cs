using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf.Meta;

namespace AgGateway.ADAPT.ADMPlugin.Protobuf.V1.Guidance
{
  public static class GuidanceShiftType
  {
    public static void Configure(RuntimeTypeModel model)
    {
      var type = model.Add(typeof(AgGateway.ADAPT.ApplicationDataModel.Guidance.GuidanceShift), Constants.UseDefaults);
      type.AddField(298, nameof(AgGateway.ADAPT.ApplicationDataModel.Guidance.GuidanceShift.GuidanceGroupId));
      type.AddField(299, nameof(AgGateway.ADAPT.ApplicationDataModel.Guidance.GuidanceShift.GuidancePatterId));
      type.AddField(300, nameof(AgGateway.ADAPT.ApplicationDataModel.Guidance.GuidanceShift.EastShift));
      type.AddField(301, nameof(AgGateway.ADAPT.ApplicationDataModel.Guidance.GuidanceShift.NorthShift));
      type.AddField(302, nameof(AgGateway.ADAPT.ApplicationDataModel.Guidance.GuidanceShift.PropagationOffset));
      type.AddField(303, nameof(AgGateway.ADAPT.ApplicationDataModel.Guidance.GuidanceShift.TimeScopeIds));
    }
  }
}
