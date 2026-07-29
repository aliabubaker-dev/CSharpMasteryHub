// Back to top button
document.addEventListener('DOMContentLoaded', function () {
    const backToTopBtn = document.createElement('a');
    backToTopBtn.className = 'back-to-top';
    backToTopBtn.innerHTML = '<i class="fas fa-arrow-up"></i>';
    backToTopBtn.href = '#';
    backToTopBtn.setAttribute('aria-label', 'Back to top');
    document.body.appendChild(backToTopBtn);

    window.addEventListener('scroll', function () {
        if (window.scrollY > 300) {
            backToTopBtn.style.display = 'flex';
        } else {
            backToTopBtn.style.display = 'none';
        }
    });

    backToTopBtn.addEventListener('click', function (e) {
        e.preventDefault();
        window.scrollTo({ top: 0, behavior: 'smooth' });
    });

    // Highlight code blocks
    document.querySelectorAll('pre code').forEach(function (block) {
        if (typeof hljs !== 'undefined') {
            hljs.highlightBlock(block);
        }
    });
});

// Search functionality (basic)
function searchLessons(query) {
    const cards = document.querySelectorAll('.lesson-card');
    const searchTerm = query.toLowerCase().trim();

    cards.forEach(card => {
        const text = card.textContent.toLowerCase();
        if (searchTerm === '' || text.includes(searchTerm)) {
            card.style.display = 'block';
        } else {
            card.style.display = 'none';
        }
    });
}

// Progress tracking (local storage)
function saveProgress(page, completed) {
    const progress = JSON.parse(localStorage.getItem('lessonProgress') || '{}');
    progress[page] = completed;
    localStorage.setItem('lessonProgress', JSON.stringify(progress));
}

function getProgress(page) {
    const progress = JSON.parse(localStorage.getItem('lessonProgress') || '{}');
    return progress[page] || false;
}

// Initialize progress indicators
document.addEventListener('DOMContentLoaded', function () {
    document.querySelectorAll('.mark-complete').forEach(btn => {
        const page = btn.dataset.page;
        if (getProgress(page)) {
            btn.classList.add('completed');
            btn.textContent = '✓ Completed';
        }

        btn.addEventListener('click', function () {
            const page = this.dataset.page;
            const completed = !getProgress(page);
            saveProgress(page, completed);
            this.classList.toggle('completed');
            this.textContent = completed ? '✓ Completed' : 'Mark as Complete';
        });
    });
});