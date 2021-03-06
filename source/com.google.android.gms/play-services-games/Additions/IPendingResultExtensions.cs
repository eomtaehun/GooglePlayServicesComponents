﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.Gms.Common.Apis;
using Android.Runtime;

namespace Android.Gms.Games
{
    public partial class GamesClass
    {
        public async Task<Statuses> SignOutAsync (GoogleApiClient apiClient)
        {
            return (await SignOut (apiClient)).JavaCast<Statuses> ();
        }
    }

    public static partial class IGamesMetadataExtensions
    {
        public static async Task<IGamesMetadataLoadGamesResult> LoadGameAsync (this IGamesMetadata api, GoogleApiClient apiClient)
        {
            return (await api.LoadGame (apiClient)).JavaCast<IGamesMetadataLoadGamesResult> ();
        }
    }

    public static partial class IPlayersExtensions
    {
        [Obsolete]
        public static async Task<IPlayersLoadPlayersResult> LoadConnectedPlayersAsync (this IPlayers api, GoogleApiClient apiClient, bool forceReload)
        {
            return (await api.LoadConnectedPlayers (apiClient, forceReload)).JavaCast<IPlayersLoadPlayersResult> ();
        }
        [Obsolete]
        public static async Task<IPlayersLoadPlayersResult> LoadInvitablePlayersAsync (this IPlayers api, GoogleApiClient apiClient, int pageSize, bool forceReload)
        {
            return (await api.LoadInvitablePlayers (apiClient, pageSize, forceReload)).JavaCast<IPlayersLoadPlayersResult> ();
        }
        [Obsolete]
        public static async Task<IPlayersLoadPlayersResult> LoadMoreInvitablePlayersAsync (this IPlayers api, GoogleApiClient apiClient, int pageSize)
        {
            return (await api.LoadMoreInvitablePlayers (apiClient, pageSize)).JavaCast<IPlayersLoadPlayersResult> ();
        }
        public static async Task<IPlayersLoadPlayersResult> LoadMoreRecentlyPlayedWithPlayersAsync (this IPlayers api, GoogleApiClient apiClient, int pageSize)
        {
            return (await api.LoadMoreRecentlyPlayedWithPlayers (apiClient, pageSize)).JavaCast<IPlayersLoadPlayersResult> ();
        }
        public static async Task<IPlayersLoadPlayersResult> LoadPlayerAsync (this IPlayers api, GoogleApiClient apiClient, string playerId)
        {
            return (await api.LoadPlayer (apiClient, playerId)).JavaCast<IPlayersLoadPlayersResult> ();
        }
        public static async Task<IPlayersLoadPlayersResult> LoadPlayerAsync (this IPlayers api, GoogleApiClient apiClient, string playerId, bool forceReload)
        {
            return (await api.LoadPlayer (apiClient, playerId, forceReload)).JavaCast<IPlayersLoadPlayersResult> ();
        }
        public static async Task<IPlayersLoadPlayersResult> LoadRecentlyPlayedWithPlayersAsync (this IPlayers api, GoogleApiClient apiClient, int pageSize, bool forceReload)
        {
            return (await api.LoadRecentlyPlayedWithPlayers (apiClient, pageSize, forceReload)).JavaCast<IPlayersLoadPlayersResult> ();
        }
    }
}
namespace Android.Gms.Games.Achievement
{
    public static partial class IAchievementsExtensions
    {
        public static async Task<IAchievementsUpdateAchievementResult> IncrementImmediateAsync (this IAchievements api, GoogleApiClient apiClient, string id, int numSteps)
        {
            return (await api.IncrementImmediate (apiClient, id, numSteps)).JavaCast<IAchievementsUpdateAchievementResult> ();
        }
        public static async Task<IAchievementsLoadAchievementsResult> LoadAsync (this IAchievements api, GoogleApiClient apiClient, bool forceReload)
        {
            return (await api.Load (apiClient, forceReload)).JavaCast<IAchievementsLoadAchievementsResult> ();
        }
        public static async Task<IAchievementsUpdateAchievementResult> RevealImmediateAsync (this IAchievements api, GoogleApiClient apiClient, string id)
        {
            return (await api.RevealImmediate (apiClient, id)).JavaCast<IAchievementsUpdateAchievementResult> ();
        }
        public static async Task<IAchievementsUpdateAchievementResult> SetStepsImmediateAsync (this IAchievements api, GoogleApiClient apiClient, string id, int numSteps)
        {
            return (await api.SetStepsImmediate (apiClient, id, numSteps)).JavaCast<IAchievementsUpdateAchievementResult> ();
        }
        public static async Task<IAchievementsUpdateAchievementResult> UnlockImmediateAsync (this IAchievements api, GoogleApiClient apiClient, string id)
        {
            return (await api.UnlockImmediate (apiClient, id)).JavaCast<IAchievementsUpdateAchievementResult> ();
        }
    }
}
namespace Android.Gms.Games.Event
{
    public static partial class IEventsExtensions
    {
        public static async Task<IEventsLoadEventsResult> LoadAsync (this IEvents api, GoogleApiClient apiClient, bool forceReload)
        {
            return (await api.Load (apiClient, forceReload)).JavaCast<IEventsLoadEventsResult> ();
        }
        public static async Task<IEventsLoadEventsResult> LoadByIdsAsync (this IEvents api, GoogleApiClient apiClient, bool forceReload, params string [] eventIds)
        {
            return (await api.LoadByIds (apiClient, forceReload, eventIds)).JavaCast<IEventsLoadEventsResult> ();
        }
    }
}
namespace Android.Gms.Games.LeaderBoard
{
    public static partial class ILeaderboardsExtensions
    {
        public static async Task<ILeaderboardsLoadPlayerScoreResult> LoadCurrentPlayerLeaderboardScoreAsync (this ILeaderboards api, GoogleApiClient apiClient, string leaderboardId, int span, int leaderboardCollection)
        {
            return (await api.LoadCurrentPlayerLeaderboardScore (apiClient, leaderboardId, span, leaderboardCollection)).JavaCast<ILeaderboardsLoadPlayerScoreResult> ();
        }
        public static async Task<ILeaderboardsLeaderboardMetadataResult> LoadLeaderboardMetadataAsync (this ILeaderboards api, GoogleApiClient apiClient, string leaderboardId, bool forceReload)
        {
            return (await api.LoadLeaderboardMetadata (apiClient, leaderboardId, forceReload)).JavaCast<ILeaderboardsLeaderboardMetadataResult> ();
        }
        public static async Task<ILeaderboardsLeaderboardMetadataResult> LoadLeaderboardMetadataAsync (this ILeaderboards api, GoogleApiClient apiClient, bool forceReload)
        {
            return (await api.LoadLeaderboardMetadata (apiClient, forceReload)).JavaCast<ILeaderboardsLeaderboardMetadataResult> ();
        }
        public static async Task<ILeaderboardsLoadScoresResult> LoadMoreScoresAsync (this ILeaderboards api, GoogleApiClient apiClient, LeaderboardScoreBuffer buffer, int maxResults, int pageDirection)
        {
            return (await api.LoadMoreScores (apiClient, buffer, maxResults, pageDirection)).JavaCast<ILeaderboardsLoadScoresResult> ();
        }
        public static async Task<ILeaderboardsLoadScoresResult> LoadPlayerCenteredScoresAsync (this ILeaderboards api, GoogleApiClient apiClient, string leaderboardId, int span, int leaderboardCollection, int maxResults)
        {
            return (await api.LoadPlayerCenteredScores (apiClient, leaderboardId, span, leaderboardCollection, maxResults)).JavaCast<ILeaderboardsLoadScoresResult> ();
        }
        public static async Task<ILeaderboardsLoadScoresResult> LoadPlayerCenteredScoresAsync (this ILeaderboards api, GoogleApiClient apiClient, string leaderboardId, int span, int leaderboardCollection, int maxResults, bool forceReload)
        {
            return (await api.LoadPlayerCenteredScores (apiClient, leaderboardId, span, leaderboardCollection, maxResults, forceReload)).JavaCast<ILeaderboardsLoadScoresResult> ();
        }
        public static async Task<ILeaderboardsLoadScoresResult> LoadTopScoresAsync (this ILeaderboards api, GoogleApiClient apiClient, string leaderboardId, int span, int leaderboardCollection, int maxResults)
        {
            return (await api.LoadTopScores (apiClient, leaderboardId, span, leaderboardCollection, maxResults)).JavaCast<ILeaderboardsLoadScoresResult> ();
        }
        public static async Task<ILeaderboardsLoadScoresResult> LoadTopScoresAsync (this ILeaderboards api, GoogleApiClient apiClient, string leaderboardId, int span, int leaderboardCollection, int maxResults, bool forceReload)
        {
            return (await api.LoadTopScores (apiClient, leaderboardId, span, leaderboardCollection, maxResults, forceReload)).JavaCast<ILeaderboardsLoadScoresResult> ();
        }
        public static async Task<ILeaderboardsSubmitScoreResult> SubmitScoreImmediateAsync (this ILeaderboards api, GoogleApiClient apiClient, string leaderboardId, long score)
        {
            return (await api.SubmitScoreImmediate (apiClient, leaderboardId, score)).JavaCast<ILeaderboardsSubmitScoreResult> ();
        }
        public static async Task<ILeaderboardsSubmitScoreResult> SubmitScoreImmediateAsync (this ILeaderboards api, GoogleApiClient apiClient, string leaderboardId, long score, string scoreTag)
        {
            return (await api.SubmitScoreImmediate (apiClient, leaderboardId, score, scoreTag)).JavaCast<ILeaderboardsSubmitScoreResult> ();
        }
    }
}
namespace Android.Gms.Games.Snapshot
{
    public static partial class ISnapshotsExtensions
    {
        public static async Task<ISnapshotsCommitSnapshotResult> CommitAndCloseAsync (this ISnapshots api, GoogleApiClient apiClient, ISnapshot snapshot, ISnapshotMetadataChange metadataChange)
        {
            return (await api.CommitAndClose (apiClient, snapshot, metadataChange)).JavaCast<ISnapshotsCommitSnapshotResult> ();
        }
        public static async Task<ISnapshotsDeleteSnapshotResult> DeleteAsync (this ISnapshots api, GoogleApiClient apiClient, ISnapshotMetadata metadata)
        {
            return (await api.Delete (apiClient, metadata)).JavaCast<ISnapshotsDeleteSnapshotResult> ();
        }
        public static async Task<ISnapshotsLoadSnapshotsResult> LoadAsync (this ISnapshots api, GoogleApiClient apiClient, bool forceReload)
        {
            return (await api.Load (apiClient, forceReload)).JavaCast<ISnapshotsLoadSnapshotsResult> ();
        }
        public static async Task<ISnapshotsOpenSnapshotResult> OpenAsync (this ISnapshots api, GoogleApiClient apiClient, ISnapshotMetadata metadata)
        {
            return (await api.Open (apiClient, metadata)).JavaCast<ISnapshotsOpenSnapshotResult> ();
        }
        public static async Task<ISnapshotsOpenSnapshotResult> OpenAsync (this ISnapshots api, GoogleApiClient apiClient, ISnapshotMetadata metadata, int conflictPolicy)
        {
            return (await api.Open (apiClient, metadata, conflictPolicy)).JavaCast<ISnapshotsOpenSnapshotResult> ();
        }
        public static async Task<ISnapshotsOpenSnapshotResult> OpenAsync (this ISnapshots api, GoogleApiClient apiClient, string fileName, bool createIfNotFound)
        {
            return (await api.Open (apiClient, fileName, createIfNotFound)).JavaCast<ISnapshotsOpenSnapshotResult> ();
        }
        public static async Task<ISnapshotsOpenSnapshotResult> OpenAsync (this ISnapshots api, GoogleApiClient apiClient, string fileName, bool createIfNotFound, int conflictPolicy)
        {
            return (await api.Open (apiClient, fileName, createIfNotFound, conflictPolicy)).JavaCast<ISnapshotsOpenSnapshotResult> ();
        }
        public static async Task<ISnapshotsOpenSnapshotResult> ResolveConflictAsync (this ISnapshots api, GoogleApiClient apiClient, string conflictId, ISnapshot snapshot)
        {
            return (await api.ResolveConflict (apiClient, conflictId, snapshot)).JavaCast<ISnapshotsOpenSnapshotResult> ();
        }
        public static async Task<ISnapshotsOpenSnapshotResult> ResolveConflictAsync (this ISnapshots api, GoogleApiClient apiClient, string conflictId, string snapshotId, ISnapshotMetadataChange metadataChange, ISnapshotContents snapshotContents)
        {
            return (await api.ResolveConflict (apiClient, conflictId, snapshotId, metadataChange, snapshotContents)).JavaCast<ISnapshotsOpenSnapshotResult> ();
        }
    }
}

namespace Android.Gms.Games.Stats
{
    public static partial class IStatsExtensions
    {
        public static async Task<IStatsLoadPlayerStatsResult> LoadPlayerStatsAsync (this IStats api, GoogleApiClient apiClient, bool forceReload)
        {
            return (await api.LoadPlayerStats (apiClient, forceReload)).JavaCast<Android.Gms.Games.Stats.IStatsLoadPlayerStatsResult> ();
        }
    }
}

namespace Android.Gms.Games.Video
{
    public static partial class IVideosExtensions
    {
        public static async Task<IVideosCaptureCapabilitiesResult> GetCaptureCapabilitiesAsync (this IVideos api, GoogleApiClient apiClient)
        {
            return (await api.GetCaptureCapabilities (apiClient)).JavaCast<IVideosCaptureCapabilitiesResult> ();
        }
        public static async Task<IVideosCaptureStateResult> GetCaptureStateAsync (this IVideos api, GoogleApiClient apiClient)
        {
            return (await api.GetCaptureState (apiClient)).JavaCast<IVideosCaptureStateResult> ();
        }
        public static async Task<IVideosCaptureAvailableResult> IsCaptureAvailableAsync (this IVideos api, GoogleApiClient apiClient, int p)
        {
            return (await api.IsCaptureAvailable (apiClient, p)).JavaCast<IVideosCaptureAvailableResult> ();
        }
    }
}