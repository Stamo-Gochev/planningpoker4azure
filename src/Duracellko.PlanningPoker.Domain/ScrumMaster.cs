﻿using System;

namespace Duracellko.PlanningPoker.Domain
{
    /// <summary>
    /// Scrum master can additionally to member start and cancel estimation planning poker.
    /// </summary>
    [Serializable]
    public class ScrumMaster : Member
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScrumMaster"/> class.
        /// </summary>
        /// <param name="team">The Scrum team, the the master is joining.</param>
        /// <param name="name">The Scrum master name.</param>
        public ScrumMaster(ScrumTeam team, string name)
            : base(team, name)
        {
        }

        /// <summary>
        /// Starts new estimation.
        /// </summary>
        public void StartEstimation()
        {
            if (Team.State == TeamState.EstimationInProgress)
            {
                throw new InvalidOperationException(Resources.Error_EstimationIsInProgress);
            }

            Team.StartEstimation();
        }

        /// <summary>
        /// Cancels current estimation.
        /// </summary>
        public void CancelEstimation()
        {
            if (Team.State == TeamState.EstimationInProgress)
            {
                Team.CancelEstimation();
            }
        }
    }
}
