using Asp.Versioning;
using Asp.Versioning.Conventions;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WorkshopBookingSystem.Extensions;

public class RouteTemplateConvention : IControllerConvention
{
    public bool Apply(IControllerConventionBuilder controller, ControllerModel controllerModel)
    {
        controller.HasApiVersion(new ApiVersion(1, 0));
        
        foreach (var selector in controllerModel.Selectors)
        {
            selector.AttributeRouteModel = new AttributeRouteModel
            {
                Template = AttributeRouteModel.CombineTemplates(
                    "api/v{version:apiVersion}",
                    selector.AttributeRouteModel?.Template)
            };
        }
        
        return true;
    }
}