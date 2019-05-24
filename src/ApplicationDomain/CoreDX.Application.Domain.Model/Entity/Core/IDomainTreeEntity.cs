﻿using System;

namespace CoreDX.Application.Domain.Model.Entity.Core
{
    public interface IDomainTreeEntity<T> : IDomainEntity, ITreeEntity<T> {}

    public interface IDomainTreeEntity<TKey, TEntity> : IDomainTreeEntity<TEntity>, IDomainEntity<TKey>, ITreeEntity<TKey, TEntity>
        where TKey : struct, IEquatable<TKey>
        where TEntity : IDomainTreeEntity<TKey, TEntity>
    {
        TKey? ParentId { get; set; }
    }
}
