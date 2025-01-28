/*
    Copyright (C) 2025 @FireNameFN
    licence: GNU Affero General Public License v3.0
    
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program. If not, see <https://www.gnu.org/licenses/>.
*/

using Content.Shared.FixedPoint;

namespace Content.Server._CorvaxNext.Footprints;

[RegisterComponent]
public sealed partial class FootprintOwnerComponent : Component
{
    [DataField]
    public FixedPoint2 MaxFootVolume = 10;

    [DataField]
    public FixedPoint2 MaxBodyVolume = 20;

    [DataField]
    public FixedPoint2 MinFootprintVolume = 0.5;

    [DataField]
    public FixedPoint2 MaxFootprintVolume = 1;

    [DataField]
    public FixedPoint2 MinBodyprintVolume = 2;

    [DataField]
    public FixedPoint2 MaxBodyprintVolume = 5;

    [DataField]
    public float FootDistance = 0.5f;

    [DataField]
    public float BodyDistance = 1;

    [ViewVariables(VVAccess.ReadWrite)]
    public float Distance;

    [DataField]
    public float NextFootOffset = 0.0625f;
}
