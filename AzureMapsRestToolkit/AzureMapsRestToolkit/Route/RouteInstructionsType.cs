﻿namespace AzureMapsToolkit.Common
{
    /// <summary>
    /// If specified, guidance instructions will be returned. Note that the instructionsType parameter cannot be used in conjunction with routeRepresentation=none
    /// </summary>
    public enum RouteInstructionsType
    {
        /// <summary>
        /// Returns raw instruction data without human-readable messages.
        /// </summary>
        coded,

        /// <summary>
        ///  Returns raw instruction data with tagged human-readable messages to permit formatting.
        /// </summary>
        tagged,

        /// <summary>
        /// Returns raw instructions data with human-readable messages in plain text.
        /// </summary>
        text
    }
}
