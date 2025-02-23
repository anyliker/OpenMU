// <copyright file="UpdateVersion.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Persistence.Initialization.Updates;

/// <summary>
/// Enum which keeps track of the <see cref="IConfigurationUpdatePlugIn.Version"/>,
/// so that it's easier to know which number is next.
/// </summary>
public enum UpdateVersion
{
    /// <summary>
    /// Undefined version.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// The version of the <see cref="ChaosCastleDataUpdatePlugIn"/>.
    /// </summary>
    ChaosCastleDataUpdate = 1,

    /// <summary>
    /// The version of the <see cref="SystemConfigurationAddedPlugInSeason6"/>.
    /// </summary>
    SystemConfigurationAddedSeason6 = 2,

    /// <summary>
    /// The version of the <see cref="SystemConfigurationAddedPlugIn095d"/>.
    /// </summary>
    SystemConfigurationAdded095d = 3,

    /// <summary>
    /// The version of the <see cref="SystemConfigurationAddedPlugIn075"/>.
    /// </summary>
    SystemConfigurationAdded075 = 4,

    /// <summary>
    /// The version of the <see cref="SpawnFixesUpdatePlugIn"/>.
    /// </summary>
    SpawnFixesUpdate = 5,

    /// <summary>
    /// The version of the <see cref="FixLevelDiv20ExcOptionUpdatePlugIn"/>.
    /// </summary>
    FixLevelDiv20ExcOptionUpdate = 6,

    /// <summary>
    /// The version of the <see cref="FixSetBonusesPlugIn.Season6"/>.
    /// </summary>
    FixSetBonusesSeason6 = 7,

    /// <summary>
    /// The version of the <see cref="FixSetBonusesPlugIn.V095d"/>.
    /// </summary>
    FixSetBonuses095d = 8,

    /// <summary>
    /// The version of the <see cref="FixSetBonusesPlugIn.V075"/>.
    /// </summary>
    FixSetBonuses075 = 9,

    /// <summary>
    /// The version of the <see cref="FixWarpLevelUpdatePlugIn"/>.
    /// </summary>
    FixWarpLevelUpdate = 10,

    /// <summary>
    /// The version of the <see cref="AddQuestItemLimitPlugIn"/>.
    /// </summary>
    AddQuestItemLimit = 11,

    /// <summary>
    /// The version of the <see cref="AddGuardsDataPlugIn"/>.
    /// </summary>
    AddGuardsData = 12,
}