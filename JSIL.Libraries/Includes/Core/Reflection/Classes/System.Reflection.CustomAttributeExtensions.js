JSIL.ImplementExternals(
  "System.Reflection.CustomAttributeExtensions", function ($) {
      $.Method({ Static: true, Public: true }, "GetCustomAttribute",
        new JSIL.MethodSignature($jsilcore.TypeRef("System.Attribute"), [$jsilcore.TypeRef("System.Reflection.MemberInfo"), $jsilcore.TypeRef("System.Type"), $.Boolean], []),
        function GetCustomAttribute(element, attributeType, inherit) {
            // FIXME: Check if TypeInfo is passed in, and if so, cast to type. Hack because TypeInfo in JSIL doesn't use Type as it's base class
            if (attributeType.FullName === "System.Reflection.TypeInfo")
                attributeType = attributeType.AsType();

            var attributes = element.GetCustomAttributes(attributeType, inherit);
            if (attributes.length === 0) {
                return null;
            } else {
                return attributes[0];
            }
        }
      );
  }
);