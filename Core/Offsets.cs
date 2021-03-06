﻿// Concept Matrix 3.
// Licensed under the MIT license.

namespace ConceptMatrix
{
	using System;
	using Anamnesis;
	using Anamnesis.Offsets;

	#pragma warning disable CS8618

	[Serializable]
	public static class Offsets
	{
		public static MainOffsetFile Main;

		public class MainOffsetFile
		{
			public ActorTableOffset ActorTable { get; set; }
			public ActorTableOffset GposeActorTable { get; set; }
			public BaseOffset Gpose { get; set; }
			public BaseOffset<bool> GposeCheck { get; set; }
			public BaseOffset<ushort> GposeCheck2 { get; set; }
			public BaseOffset Target { get; set; }
			public BaseOffset CameraAddress { get; set; }
			public BaseOffset Time { get; set; }
			public BaseOffset TerritoryAddress { get; set; }
			public BaseOffset GposeFilters { get; set; }

			public FlagOffset Skeleton1Flag { get; set; }
			public FlagOffset Skeleton2Flag { get; set; }
			public FlagOffset Skeleton3Flag { get; set; }
			public FlagOffset Skeleton4flag { get; set; }
			public FlagOffset Skeleton5Flag { get; set; }
			public FlagOffset Skeleton6Flag { get; set; }
			public FlagOffset Physics1Flag { get; set; }
			public FlagOffset Physics2Flag { get; set; }
			public FlagOffset Physics3Flag { get; set; }

			public Offset RenderOffset1 { get; set; }
			public Offset RenderOffset2 { get; set; }

			public Offset<string> Name { get; set; }
			public Offset<ActorTypes> ActorType { get; set; }
			public Offset<byte> ActorRender { get; set; }

			public Offset<Vector> Camera { get; set; }

			public Offset<Appearance> ActorAppearance { get; set; }
			public Offset<int> ModelType { get; set; }
			public Offset<bool> Animating { get; set; }

			public Offset Transparency { get; set; }
			public Offset<Weapon> MainHand { get; set; }
			public Offset<Weapon> OffHand { get; set; }
			public Offset<Equipment> ActorEquipment { get; set; }

			public Offset ForceAnimation { get; set; }
			public Offset IdleAnimation { get; set; }
			public Offset AnimationSpeed1 { get; set; }
			public Offset AnimationSpeed2 { get; set; }
			public Offset FreezeFacial { get; set; }

			public Offset DataPath { get; set; }
			public Offset DataHead { get; set; }

			public Offset<Vector> Position { get; set; }
			public Offset<Quaternion> Rotation { get; set; }
			public Offset Height { get; set; }
			public Offset Wetness { get; set; }
			public Offset Drenched { get; set; }

			public Offset<Vector> BustScale { get; set; }
			public Offset UniqueFeatureScale { get; set; }
			public Offset MuscleTone { get; set; }
			public Offset<Vector> Scale { get; set; }

			public Offset<Vector> MainHandScale { get; set; }
			public Offset<Color> MainHandColor { get; set; }
			public Offset<Vector> OffhandScale { get; set; }
			public Offset<Color> OffhandColor { get; set; }

			// Actor's RGB Values
			public Offset<Color> SkinColor { get; set; }
			public Offset<Color> SkinGloss { get; set; }
			public Offset<Color> HairColor { get; set; }
			public Offset<Color> HairGloss { get; set; }
			public Offset<Color> HairHiglight { get; set; }
			public Offset<Color> LeftEyeColor { get; set; }
			public Offset<Color> RightEyeColor { get; set; }
			public Offset<Color> MouthColor { get; set; }
			public Offset<float> MouthGloss { get; set; }
			public Offset<Color> LimbalColor { get; set; }

			public Offset<Vector> CameraView { get; set; }
			public Offset<float> CameraCurrentZoom { get; set; }
			public Offset<float> CameraMinZoom { get; set; }
			public Offset<float> CameraMaxZoom { get; set; }
			public Offset<float> FOVCurrent { get; set; }
			public Offset<Vector2D> CameraAngle { get; set; }
			public Offset<Vector2D> CameraPan { get; set; }
			public Offset<float> CameraYMin { get; set; }
			public Offset<float> CameraYMax { get; set; }
			public Offset<float> CameraRotation { get; set; }
			public Offset CameraUpDown { get; set; }

			public Offset<int> TimeControl { get; set; }
			public Offset<int> Territory { get; set; }
			public Offset<int> Weather { get; set; }
			public Offset<ushort> ForceWeather { get; set; }

			public Offset GposeFilterEnable { get; set; }
			public Offset GposeFilterTable { get; set; }

			public Offset<byte> ExHairCount { get; set; }
			public Offset<byte> ExMetCount { get; set; }
			public Offset<byte> ExTopCount { get; set; }
		}
	}
}
