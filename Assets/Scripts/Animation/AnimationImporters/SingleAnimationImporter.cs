﻿using Assets.Scripts.Animation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Animation.AnimationImporters
{
    public class SingleAnimationImporter : IAnimationImporter
    {
        List<AnimationDNABlock> IAnimationImporter.ImportAnimations(string spritesheetKey, string direction)
        {
            List<AnimationDNABlock> animationList = new List<AnimationDNABlock>();
            AnimationImportUtil builder = new AnimationImportUtil();
            animationList.Add(builder.BuildAnimation(this, spritesheetKey, direction));
            return animationList;
        }

        private string _tagName;
        private int _numberOfFrames;
        private int _spriteStartIndex;
        private bool _stopOnFinalFrame;

        public string TagName { get { return _tagName; } }
        public int NumberOfFrames { get { return _numberOfFrames; } }
        public int SpriteStartIndex { get { return _spriteStartIndex; } }
        public bool StopOnFinalFrame { get { return _stopOnFinalFrame; } }

        public SingleAnimationImporter(string tagName, int numberOfFrames, int spriteStartIndex, bool stopOnFinalFrame) {
            _tagName = tagName;
            _numberOfFrames = numberOfFrames;
            _spriteStartIndex = spriteStartIndex;
            _stopOnFinalFrame = stopOnFinalFrame;
        }
    }
}
