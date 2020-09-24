using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Catapult.Modules.Store.Protocol.Commands.Purchase;
using Catapult.Modules.Store.Protocol.Commands.Refunds.Steam;
using Catapult.Modules.Store.Protocol.Commands.Retrieve;
using Catapult.Modules.Store.Protocol.Dtos;
using Catapult.Services.Gateway.Client;
using Catapult.Services.Gateway.Protocol.Client;
using Catapult.Services.Login.Requests;
using Catapult.Services.Login.Requests.Admin;
using Catapult.Services.Login.Responses;
using FallGuys.Gateway.Protocol.Client.Matchmaking;
using FallGuys.Gateway.Protocol.Client.Matchmaking.Identity;
using FallGuys.Gateway.Protocol.Client.PlayerDisconnected;
using FallGuys.Player.Protocol.Client;
using FallGuys.Player.Protocol.Client.Achievements;
using FallGuys.Player.Protocol.Client.Challenges;
using FallGuys.Player.Protocol.Client.Cosmetics;
using FallGuys.Player.Protocol.Client.Dailies;
using FallGuys.Player.Protocol.Client.Episodes;
using FallGuys.Player.Protocol.Client.Metrics;
using FallGuys.Player.Protocol.Client.Playtime;
using FallGuys.Player.Protocol.Client.Profile;
using FallGuys.Player.Protocol.Client.Rewards;
using FallGuys.Player.Protocol.Client.Seasons;
using FallGuys.Player.Protocol.Client.Settings;
using FallGuys.Player.Protocol.Client.Wallet;
using ProtoBuf;

namespace Catapult.Protocol
{
    [ProtoContract]
    // TODO: Better way - using RuntimeTypeModel directly??

    [ProtoInclude(67755633, typeof(Result))]
    [ProtoInclude(65629432, typeof(KeepAliveMessage))]

    [ProtoInclude(80982860, typeof(Message<AuthenticationRequest>))]
    [ProtoInclude(40651534, typeof(Result<AuthenticationRequest>))]

    [ProtoInclude(12914002, typeof(Message<AuthenticationResponse>))]
    [ProtoInclude(98996885, typeof(Result<AuthenticationResponse>))]

    [ProtoInclude(78398356, typeof(Message<ContentUpdateNotification>))]
    [ProtoInclude(69778847, typeof(Result<ContentUpdateNotification>))]

    [ProtoInclude(74676737, typeof(Message<LogAnalyticsEventCommand>))]
    [ProtoInclude(3981026, typeof(Result<LogAnalyticsEventCommand>))]

    [ProtoInclude(44291478, typeof(Message<LogAnalyticsEventsCommand>))]
    [ProtoInclude(69484957, typeof(Result<LogAnalyticsEventsCommand>))]

    [ProtoInclude(91571091, typeof(Message<SessionClosedMessage>))]
    [ProtoInclude(94774973, typeof(Result<SessionClosedMessage>))]

    [ProtoInclude(96053031, typeof(Message<TimestampRequest>))]
    [ProtoInclude(46765518, typeof(Result<TimestampRequest>))]

    [ProtoInclude(1925196, typeof(Message<TimestampResponse>))]
    [ProtoInclude(20945795, typeof(Result<TimestampResponse>))]

    [ProtoInclude(68264738, typeof(Message<AddIdentityRequest>))]
    [ProtoInclude(88077515, typeof(Result<AddIdentityRequest>))]

    [ProtoInclude(15402535, typeof(Message<AuthenticateRequest>))]
    [ProtoInclude(85076456, typeof(Result<AuthenticateRequest>))]

    [ProtoInclude(45528596, typeof(Message<CreateAccountRequest>))]
    [ProtoInclude(63099721, typeof(Result<CreateAccountRequest>))]

    [ProtoInclude(59361560, typeof(Message<ForgetAccountRequest>))]
    [ProtoInclude(10224965, typeof(Result<ForgetAccountRequest>))]

    [ProtoInclude(71269765, typeof(Message<LoginRequest>))]
    [ProtoInclude(67532047, typeof(Result<LoginRequest>))]

    [ProtoInclude(11405079, typeof(Message<LookupIdentityRequest>))]
    [ProtoInclude(33243480, typeof(Result<LookupIdentityRequest>))]

    [ProtoInclude(41145022, typeof(Message<RemoveAndAddIdentityRequest>))]
    [ProtoInclude(959413, typeof(Result<RemoveAndAddIdentityRequest>))]

    [ProtoInclude(46663754, typeof(Message<RemoveIdentityRequest>))]
    [ProtoInclude(19618053, typeof(Result<RemoveIdentityRequest>))]

    [ProtoInclude(29188788, typeof(Message<AccountResponse>))]
    [ProtoInclude(80903385, typeof(Result<AccountResponse>))]

    [ProtoInclude(28237446, typeof(Message<AccountsResponse>))]
    [ProtoInclude(79569590, typeof(Result<AccountsResponse>))]

    [ProtoInclude(41984326, typeof(Message<ForgetAccountResponse>))]
    [ProtoInclude(40239113, typeof(Result<ForgetAccountResponse>))]

    [ProtoInclude(66579127, typeof(Message<IdentityResponse>))]
    [ProtoInclude(47105927, typeof(Result<IdentityResponse>))]

    [ProtoInclude(4263673, typeof(Message<IdentitiesResponse>))]
    [ProtoInclude(83935248, typeof(Result<IdentitiesResponse>))]

    [ProtoInclude(66167370, typeof(Message<LookupIdentityResponse>))]
    [ProtoInclude(70959204, typeof(Result<LookupIdentityResponse>))]

    [ProtoInclude(30493429, typeof(Message<SessionTokenResponse>))]
    [ProtoInclude(15174312, typeof(Result<SessionTokenResponse>))]

    [ProtoInclude(46250380, typeof(Message<AdminGetIdentitiesRequest>))]
    [ProtoInclude(38019471, typeof(Result<AdminGetIdentitiesRequest>))]

    [ProtoInclude(40340807, typeof(Message<AdminMigrateAccountRequest>))]
    [ProtoInclude(41586084, typeof(Result<AdminMigrateAccountRequest>))]

    [ProtoInclude(57001539, typeof(Message<AdminRemoveIdentityRequest>))]
    [ProtoInclude(29195936, typeof(Result<AdminRemoveIdentityRequest>))]

    [ProtoInclude(22023198, typeof(Message<AdminSearchUsersByIdentityRequest>))]
    [ProtoInclude(4701383, typeof(Result<AdminSearchUsersByIdentityRequest>))]

    [ProtoInclude(95807348, typeof(Message<AdminSearchUsersByIdRequest>))]
    [ProtoInclude(42102655, typeof(Result<AdminSearchUsersByIdRequest>))]

    [ProtoInclude(18959112, typeof(Message<AdminUpdateAccountRequest>))]
    [ProtoInclude(12784395, typeof(Result<AdminUpdateAccountRequest>))]

    // TODO HERE: Catapult.Services.Login.Protocol.Client.Responses.Admin.*

    [ProtoInclude(71441921, typeof(Message<GetMatchmakingIdentityQuery>))]
    [ProtoInclude(33456901, typeof(Result<GetMatchmakingIdentityQuery>))]

    [ProtoInclude(57184313, typeof(Message<MatchmakingIdentityTokenDto>))]
    [ProtoInclude(459325, typeof(Result<MatchmakingIdentityTokenDto>))]

    [ProtoInclude(81773578, typeof(Message<CancelMatchmakingCommand>))]
    [ProtoInclude(80499945, typeof(Result<CancelMatchmakingCommand>))]

    [ProtoInclude(52993236, typeof(Message<CreateGameEntryTokenCommand>))]
    [ProtoInclude(37494680, typeof(Result<CreateGameEntryTokenCommand>))]

    [ProtoInclude(82413665, typeof(Message<JoinMatchmakingCommand>))]
    [ProtoInclude(63463846, typeof(Result<JoinMatchmakingCommand>))]

    [ProtoInclude(73967366, typeof(Message<MatchFoundResponse>))]
    [ProtoInclude(89550683, typeof(Result<MatchFoundResponse>))]

    [ProtoInclude(93589701, typeof(Message<MatchmakingCancelled>))]
    [ProtoInclude(90896619, typeof(Result<MatchmakingCancelled>))]

    [ProtoInclude(50195745, typeof(Message<MatchmakingSessionDto>))]
    [ProtoInclude(73067244, typeof(Result<MatchmakingSessionDto>))]

    [ProtoInclude(30481731, typeof(Message<QosResultDto>))]
    [ProtoInclude(58287520, typeof(Result<QosResultDto>))]

    [ProtoInclude(48808317, typeof(Message<QosResultsDto>))]
    [ProtoInclude(61444982, typeof(Result<QosResultsDto>))]

    [ProtoInclude(78770768, typeof(Message<GameServerDisconnectNotification>))]
    [ProtoInclude(15049104, typeof(Result<GameServerDisconnectNotification>))]

    [ProtoInclude(65947560, typeof(Message<ColourSchemeDto>))]
    [ProtoInclude(1159431, typeof(Result<ColourSchemeDto>))]

    [ProtoInclude(55975865, typeof(Message<ConfigureEmotesCommand>))]
    [ProtoInclude(15587323, typeof(Result<ConfigureEmotesCommand>))]

    [ProtoInclude(38962858, typeof(Message<ConfigureLoadoutCommand>))]
    [ProtoInclude(82416611, typeof(Result<ConfigureLoadoutCommand>))]

    [ProtoInclude(72138523, typeof(Message<CosmeticsCollectionDto>))]
    [ProtoInclude(69626923, typeof(Result<CosmeticsCollectionDto>))]

    [ProtoInclude(34462460, typeof(Message<EmoteDto>))]
    [ProtoInclude(10528616, typeof(Result<EmoteDto>))]

    [ProtoInclude(39313225, typeof(Message<FaceplateDto>))]
    [ProtoInclude(47254676, typeof(Result<FaceplateDto>))]

    [ProtoInclude(53379743, typeof(Message<GetCosmeticsCollectionQuery>))]
    [ProtoInclude(74147792, typeof(Result<GetCosmeticsCollectionQuery>))]

    [ProtoInclude(27154824, typeof(Message<GetLoadoutQuery>))]
    [ProtoInclude(36561191, typeof(Result<GetLoadoutQuery>))]

    [ProtoInclude(35678302, typeof(Message<GrantAllCosmeticsToPlayerCommand>))]
    [ProtoInclude(53794951, typeof(Result<GrantAllCosmeticsToPlayerCommand>))]

    [ProtoInclude(77099385, typeof(Message<ItemsLeftToGrantDto>))]
    [ProtoInclude(26236964, typeof(Result<ItemsLeftToGrantDto>))]

    [ProtoInclude(29988723, typeof(Message<LoadoutDto>))]
    [ProtoInclude(83608096, typeof(Result<LoadoutDto>))]

    [ProtoInclude(4884262, typeof(Message<LowerCostumePieceDto>))]
    [ProtoInclude(43892004, typeof(Result<LowerCostumePieceDto>))]

    [ProtoInclude(90747429, typeof(Message<MonolithicCostumeDto>))]
    [ProtoInclude(61590890, typeof(Result<MonolithicCostumeDto>))]

    [ProtoInclude(46543335, typeof(Message<NameplateDto>))]
    [ProtoInclude(32962354, typeof(Result<NameplateDto>))]

    [ProtoInclude(44848839, typeof(Message<NicknameDto>))]
    [ProtoInclude(48745037, typeof(Result<NicknameDto>))]

    [ProtoInclude(45212202, typeof(Message<PatternDto>))]
    [ProtoInclude(93828473, typeof(Result<PatternDto>))]

    [ProtoInclude(37722862, typeof(Message<PlinthDto>))]
    [ProtoInclude(53889923, typeof(Result<PlinthDto>))]

    [ProtoInclude(50810984, typeof(Message<PunchlineDto>))]
    [ProtoInclude(35746741, typeof(Result<PunchlineDto>))]

    [ProtoInclude(56043201, typeof(Message<UpperCostumePieceDto>))]
    [ProtoInclude(92433347, typeof(Result<UpperCostumePieceDto>))]

    [ProtoInclude(70736946, typeof(Message<AchievementDto>))]
    [ProtoInclude(72103519, typeof(Result<AchievementDto>))]

    [ProtoInclude(88000647, typeof(Message<AchievementsCompletedNotificationDto>))]
    [ProtoInclude(18304132, typeof(Result<AchievementsCompletedNotificationDto>))]

    [ProtoInclude(73712920, typeof(Message<AchievementsDto>))]
    [ProtoInclude(40234024, typeof(Result<AchievementsDto>))]

    [ProtoInclude(25187954, typeof(Message<GetAchievementsQuery>))]
    [ProtoInclude(63936061, typeof(Result<GetAchievementsQuery>))]

    [ProtoInclude(51978703, typeof(Message<GetCompletedAchievementsQuery>))]
    [ProtoInclude(93123130, typeof(Result<GetCompletedAchievementsQuery>))]

    [ProtoInclude(10714276, typeof(Message<ChallengeDto>))]
    [ProtoInclude(98596977, typeof(Result<ChallengeDto>))]

    [ProtoInclude(30412429, typeof(Message<ChallengesDto>))]
    [ProtoInclude(18238095, typeof(Result<ChallengesDto>))]

    [ProtoInclude(54641311, typeof(Message<GetChallengesQuery>))]
    [ProtoInclude(8227920, typeof(Result<GetChallengesQuery>))]

    [ProtoInclude(95256239, typeof(Message<DailiesDto>))]
    [ProtoInclude(54251809, typeof(Result<DailiesDto>))]

    [ProtoInclude(34216945, typeof(Message<DailyDto>))]
    [ProtoInclude(99735902, typeof(Result<DailyDto>))]

    [ProtoInclude(57307880, typeof(Message<GetDailiesQuery>))]
    [ProtoInclude(61405912, typeof(Result<GetDailiesQuery>))]

    [ProtoInclude(85441119, typeof(Message<RefreshDailiesCommand>))]
    [ProtoInclude(69347441, typeof(Result<RefreshDailiesCommand>))]

    [ProtoInclude(38337111, typeof(Message<CompletedEpisodeDto>))]
    [ProtoInclude(20763914, typeof(Result<CompletedEpisodeDto>))]

    [ProtoInclude(9930125, typeof(Message<CompletedRoundDto>))]
    [ProtoInclude(28669540, typeof(Result<CompletedRoundDto>))]

    [ProtoInclude(7070387, typeof(Message<EpisodeHistoryDto>))]
    [ProtoInclude(47662397, typeof(Result<EpisodeHistoryDto>))]

    [ProtoInclude(56471451, typeof(Message<GetEpisodeHistoryQuery>))]
    [ProtoInclude(64694489, typeof(Result<GetEpisodeHistoryQuery>))]

    [ProtoInclude(11340064, typeof(Message<RoundReportDto>))]
    [ProtoInclude(68767565, typeof(Result<RoundReportDto>))]

    [ProtoInclude(43848924, typeof(Message<SeasonProgressDto>))]
    [ProtoInclude(94823221, typeof(Result<SeasonProgressDto>))]

    [ProtoInclude(34106402, typeof(Message<LogMetricUpdateCommand>))]
    [ProtoInclude(85816160, typeof(Result<LogMetricUpdateCommand>))]

    [ProtoInclude(79870922, typeof(Message<MetricUpdateDto>))]
    [ProtoInclude(75419898, typeof(Result<MetricUpdateDto>))]

    [ProtoInclude(70299585, typeof(Message<PlaytimeWarningDto>))]
    [ProtoInclude(18893838, typeof(Result<PlaytimeWarningDto>))]

    [ProtoInclude(60278532, typeof(Message<FallTagDto>))]
    [ProtoInclude(16420746, typeof(Result<FallTagDto>))]

    [ProtoInclude(42910206, typeof(Message<GetProfileQuery>))]
    [ProtoInclude(75521230, typeof(Result<GetProfileQuery>))]

    [ProtoInclude(99325626, typeof(Message<ProfileDto>))]
    [ProtoInclude(77382964, typeof(Result<ProfileDto>))]

    [ProtoInclude(94331896, typeof(Message<ClaimRewardCommand>))]
    [ProtoInclude(95583031, typeof(Result<ClaimRewardCommand>))]

    [ProtoInclude(79380275, typeof(Message<GetUnclaimedRewardsQuery>))]
    [ProtoInclude(72197424, typeof(Result<GetUnclaimedRewardsQuery>))]

    [ProtoInclude(78897192, typeof(Message<RewardClaimedDto>))]
    [ProtoInclude(9955425, typeof(Result<RewardClaimedDto>))]

    [ProtoInclude(86019758, typeof(Message<RewardDto>))]
    [ProtoInclude(47538115, typeof(Result<RewardDto>))]

    [ProtoInclude(70186332, typeof(Message<UnclaimedRewardsDto>))]
    [ProtoInclude(21050625, typeof(Result<UnclaimedRewardsDto>))]

    [ProtoInclude(79892169, typeof(Message<GetPlayerSeasonQuery>))]
    [ProtoInclude(1200262, typeof(Result<GetPlayerSeasonQuery>))]

    [ProtoInclude(54499517, typeof(Message<PlayerSeasonDto>))]
    [ProtoInclude(16714381, typeof(Result<PlayerSeasonDto>))]

    [ProtoInclude(52699510, typeof(Message<SeasonCompletedDto>))]
    [ProtoInclude(47516857, typeof(Result<SeasonCompletedDto>))]

    [ProtoInclude(80350317, typeof(Message<SeasonFameTierDto>))]
    [ProtoInclude(60275588, typeof(Result<SeasonFameTierDto>))]

    [ProtoInclude(56822907, typeof(Message<SeasonRecordDto>))]
    [ProtoInclude(75426354, typeof(Result<SeasonRecordDto>))]

    [ProtoInclude(98634880, typeof(Message<ConfigureSettingsCommand>))]
    [ProtoInclude(56182147, typeof(Result<ConfigureSettingsCommand>))]

    [ProtoInclude(71055462, typeof(Message<GetAllSettingsQuery>))]
    [ProtoInclude(53747515, typeof(Result<GetAllSettingsQuery>))]

    [ProtoInclude(73306849, typeof(Message<SettingsDto>))]
    [ProtoInclude(42001771, typeof(Result<SettingsDto>))]
    
    [ProtoInclude(8136670, typeof(Message<GetWalletQuery>))]
    [ProtoInclude(21100087, typeof(Result<GetWalletQuery>))]

    [ProtoInclude(39923681, typeof(Message<WalletDto>))]
    [ProtoInclude(90130492, typeof(Result<WalletDto>))]

    [ProtoInclude(14318796, typeof(Message<InitializePlayerStateCommand>))]
    [ProtoInclude(30168633, typeof(Result<InitializePlayerStateCommand>))]

    [ProtoInclude(72163209, typeof(Message<CompletedPurchaseDto>))]
    [ProtoInclude(55917780, typeof(Result<CompletedPurchaseDto>))]

    [ProtoInclude(56701170, typeof(Message<CompletedPurchasesDto>))]
    [ProtoInclude(51487933, typeof(Result<CompletedPurchasesDto>))]

    [ProtoInclude(55298267, typeof(Message<IapPaymentDto>))]
    [ProtoInclude(7512334, typeof(Result<IapPaymentDto>))]

    [ProtoInclude(38899458, typeof(Message<ItemPaymentDto>))]
    [ProtoInclude(21590623, typeof(Result<ItemPaymentDto>))]

    [ProtoInclude(98055857, typeof(Message<ItemPaymentLineDto>))]
    [ProtoInclude(51020120, typeof(Result<ItemPaymentLineDto>))]

    [ProtoInclude(33915239, typeof(Message<NoPaymentDto>))]
    [ProtoInclude(15306126, typeof(Result<NoPaymentDto>))]

    [ProtoInclude(47729546, typeof(Message<PaymentDto>))]
    [ProtoInclude(73910714, typeof(Result<PaymentDto>))]

    [ProtoInclude(21878841, typeof(Message<StoreBundleDto>))]
    [ProtoInclude(27734331, typeof(Result<StoreBundleDto>))]

    [ProtoInclude(7770194, typeof(Message<StoreBundleItemDto>))]
    [ProtoInclude(59261371, typeof(Result<StoreBundleItemDto>))]

    [ProtoInclude(42084597, typeof(Message<StoreBundleRewardDto>))]
    [ProtoInclude(26103208, typeof(Result<StoreBundleRewardDto>))]

    [ProtoInclude(50126092, typeof(Message<StoreDto>))]
    [ProtoInclude(72044261, typeof(Result<StoreDto>))]

    [ProtoInclude(90834796, typeof(Message<StoreSectionDto>))]
    [ProtoInclude(52942593, typeof(Result<StoreSectionDto>))]

    [ProtoInclude(23292370, typeof(Message<GetStoreQuery>))]
    [ProtoInclude(40653319, typeof(Result<GetStoreQuery>))]

    [ProtoInclude(10747096, typeof(Message<Order>))]
    [ProtoInclude(72318645, typeof(Result<Order>))]

    [ProtoInclude(10346889, typeof(Message<ProcessRefundedSteamTransactionsCommand>))]
    [ProtoInclude(77852733, typeof(Result<ProcessRefundedSteamTransactionsCommand>))]

    [ProtoInclude(55986356, typeof(Message<StoreItem>))]
    [ProtoInclude(51471030, typeof(Result<StoreItem>))]

    [ProtoInclude(27512910, typeof(Message<AndroidReceiptPaymentOption>))]
    [ProtoInclude(57228015, typeof(Result<AndroidReceiptPaymentOption>))]

    [ProtoInclude(50969345, typeof(Message<AppleReceiptPaymentOption>))]
    [ProtoInclude(85468041, typeof(Result<AppleReceiptPaymentOption>))]

    [ProtoInclude(37033462, typeof(Message<CheckSteamDlcCommand>))]
    [ProtoInclude(21713323, typeof(Result<CheckSteamDlcCommand>))]

    [ProtoInclude(96525105, typeof(Message<InitSteamTransactionCommand>))]
    [ProtoInclude(77467962, typeof(Result<InitSteamTransactionCommand>))]

    [ProtoInclude(81360378, typeof(Message<ItemPaymentLine>))]
    [ProtoInclude(58230009, typeof(Result<ItemPaymentLine>))]

    [ProtoInclude(79327018, typeof(Message<ItemPaymentOption>))]
    [ProtoInclude(17279176, typeof(Result<ItemPaymentOption>))]

    [ProtoInclude(37807982, typeof(Message<NoPaymentOption>))]
    [ProtoInclude(57449594, typeof(Result<NoPaymentOption>))]

    [ProtoInclude(82895858, typeof(Message<PaymentOption>))]
    [ProtoInclude(70390591, typeof(Result<PaymentOption>))]

    [ProtoInclude(31819936, typeof(Message<ProcessPendingPsnDlcPurchasesCommand>))]
    [ProtoInclude(2762849, typeof(Result<ProcessPendingPsnDlcPurchasesCommand>))]

    [ProtoInclude(79762145, typeof(Message<PsnPaymentOption>))]
    [ProtoInclude(21703397, typeof(Result<PsnPaymentOption>))]

    [ProtoInclude(54741114, typeof(Message<PurchaseBundleCommand>))]
    [ProtoInclude(23060789, typeof(Result<PurchaseBundleCommand>))]

    [ProtoInclude(58340947, typeof(Message<SteamPaymentOption>))]
    [ProtoInclude(75065291, typeof(Result<SteamPaymentOption>))]

    [ProtoInclude(49147380, typeof(Message<SteamTransactionResult>))]
    [ProtoInclude(56284890, typeof(Result<SteamTransactionResult>))]

    [ProtoInclude(66142919, typeof(Message<WindowsReceiptPaymentOption>))]
    [ProtoInclude(73693030, typeof(Result<WindowsReceiptPaymentOption>))]
    public class Message : IMessage
    {
        [ProtoMember(1)]
        public List<MessageHeader> Headers { get; set; }

        public Message()
        {
        }

        public void AttachHeader<THeader>(THeader header) where THeader : MessageHeader
        {
            if (Headers == null)
                Headers = new List<MessageHeader>();

            Headers.Add(header);
        }

        public THeader GetHeader<THeader>() where THeader : MessageHeader
        {
            if (Headers == null) return null;

            foreach (var header in Headers)
            {
                if (header.GetType() == typeof(THeader))
                    return (THeader)header;
            }

            return null;
        }
        public void RemoveHeader<THeader>() where THeader : MessageHeader
        {
            Headers?.RemoveAll(header => header.GetType() == typeof(THeader));
        }

        public void ClearHeaders()
        {
            Headers?.Clear();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(GetTypeName());
            sb.AppendLine("Headers:");

            if (Headers != null)
            {
                foreach (var header in Headers)
                {
                    sb.AppendFormat("{0}:{1}\n", header.GetType().Namespace,
                        header.GetType().Name); // TODO: Search for proper arguments - not easy to dig these ones
                }
            }

            return sb.ToString();
        }

        public virtual string GetTypeName()
        {
            return GetType().Name;
        }
    }

    [ProtoContract]
    public class Message<TBody> : Message
    {
        [ProtoMember(1)]
        public TBody Body { get; set; }

        public Message()
        {

        }

        public Message(TBody body)
        {
            Body = body;
        }

        public override string GetTypeName()
        {
            return $"Message<{typeof(TBody).Name}>";
        }
    }
}
