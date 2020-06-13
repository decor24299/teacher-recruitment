using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace teacher_recruitment_app.Utilities
{
    public class ShouldSerializeContractResolver : DefaultContractResolver
    {
        private List<string> serializableProperties;


        public ShouldSerializeContractResolver(List<string> serializableProperties)
        {
            this.serializableProperties = serializableProperties;
            NamingStrategy = new SnakeCaseNamingStrategy();
        }

        protected override JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            property.ShouldSerialize = instance => serializableProperties.Contains(member.Name.ToLower());
            return property;
        }
    }
}