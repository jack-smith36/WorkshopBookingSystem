using Asp.Versioning;
using Asp.Versioning.Conventions;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WorkshopBookingSystem.Extensions;

public class RouteTemplateConvention : IControllerConvention
{
    public bool Apply(IControllerConventionBuilder controller, ControllerModel controllerModel)
    {
        var controllerNamespace = controllerModel.ControllerType.Namespace;

        if (controllerNamespace is null)
        {
            return false;
        }
        
        var namespaceVersion = controllerNamespace.Split(".").Last().Replace("V", "");
        var version = new ApiVersion(int.Parse(namespaceVersion), 0);
        controller.HasApiVersion(version);
        
        foreach (var selector in controllerModel.Selectors)
        {
            selector.AttributeRouteModel = new AttributeRouteModel
            {
                Template = AttributeRouteModel.CombineTemplates("api/v{version:apiVersion}", selector.AttributeRouteModel?.Template)
            };
        }
        
        return true;
    }
}