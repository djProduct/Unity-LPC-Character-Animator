﻿using Assets.Scripts.Animation.AnimationImporters;
using Assets.Scripts.Animation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Animation.ActionAnimations
{
    class SpellcastAction : BaseAction {
        public override IAnimationImporter GetAnimationImporter() {
            SingleAnimationImporter downAnimation = new SingleAnimationImporter(
                String.Format("{0}_d", GetAnimationTag()), _numberOfFrames, 6, GetStopOnLastFrame());
            SingleAnimationImporter leftAnimation = new SingleAnimationImporter(
                String.Format("{0}_l", GetAnimationTag()), _numberOfFrames, 13, GetStopOnLastFrame());
            SingleAnimationImporter rightAnimation = new SingleAnimationImporter(
                String.Format("{0}_r", GetAnimationTag()), _numberOfFrames, 20, GetStopOnLastFrame());
            SingleAnimationImporter upAnimation = new SingleAnimationImporter(
                String.Format("{0}_t", GetAnimationTag()), _numberOfFrames, 27, GetStopOnLastFrame());
            return new WASDAnimationImporter(upAnimation, leftAnimation, downAnimation, rightAnimation);
        }

        public SpellcastAction() : base() {
            _numberOfFrames = 7;
        }

        public override string GetAnimationTag() {
            return "sc";
        }

        public override string GetAnimationType() {
            return "spellcast";
        }

        public override bool GetStopOnLastFrame() {
            return false;
        }
    }
}
