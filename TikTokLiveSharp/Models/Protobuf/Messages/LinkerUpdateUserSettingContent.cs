using ProtoBuf;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class LinkerUpdateUserSettingContent : AProtoBase
    {
        [ProtoMember(1)]
        public LinkmicUserSettingInfo UpdateUserSettingInfo { get; }
    }
}
